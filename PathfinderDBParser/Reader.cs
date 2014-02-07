using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDBParser
{
    public abstract class Reader<T> where T : class
    {
        public string File { get; set; }

        protected CsvReader csvReader;
        private Stream reader;

        protected List<T> ReadAll()
        {
            List<T> rowList;
            try
            {
                rowList = csvReader.GetRecords<T>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Reading file:");
                Console.WriteLine(ex);
                rowList = new List<T>();
            }
            return rowList;
        }

        protected void CreateDatabase(IEnumerable<T> entities, string tableName)
        {
            using (var db = new EntityContext<T>(tableName))
            {
                try
                {
                    db.Database.ExecuteSqlCommand("delete from " + db.TableName);
                    db.SaveChangesAsync();

                    db.Entities.AddRange(entities);
                    db.SaveChangesAsync();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        }
                    }

                    throw;
                }
            }
        }

        public Reader(string file)
        {
            File = file;

            csvReader = new CsvReader(new StreamReader(File));
        }

        public Reader(Stream reader)
        {
            File = null;
            csvReader = new CsvReader(new StreamReader(reader));
        }
    }

    public class EntityContext<T> : DbContext where T : class
    {
        public string TableName { get; set; }

        public EntityContext()
            : base("name=MonsterContext")
        {
        }

        public EntityContext(string tableName)
            : base("name=MonsterContext")
        {
            this.TableName = tableName;
        }

        public DbSet<T> Entities { get; set; }
    }
}