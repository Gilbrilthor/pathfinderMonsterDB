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
    public class EntityContext<T> : DbContext where T : class
    {
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

        public string TableName { get; set; }
    }

    public class Reader<T> where T : class
    {
        protected CsvReader csvReader;

        private List<T> items;

        public Reader(string file)
        {
            File = file;

            TableName = TableNameLookup.GetTableName<T>();

            csvReader = new CsvReader(new StreamReader(File));
        }

        public Reader(Stream reader)
        {
            File = null;
            TableName = TableNameLookup.GetTableName<T>();
            csvReader = new CsvReader(new StreamReader(reader));
        }

        public string File { get; set; }

        public List<T> Items
        {
            get
            {
                if (items == null)
                {
                    items = ReadAll();
                }
                return items;
            }
            private set { items = value; }
        }

        public string TableName { get; set; }

        public void CreateDatabase(IEnumerable<T> entities)
        {
            using (var db = new EntityContext<T>(TableName))
            {
                try
                {
                    db.Database.ExecuteSqlCommand("delete from " + TableName);
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

        protected List<T> ReadAll()
        {
            List<T> rowList;
            rowList = csvReader.GetRecords<T>().ToList();
            return rowList;
        }
    }
}