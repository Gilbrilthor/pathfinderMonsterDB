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
    public class MonsterReader
    {
        private List<Monster> monsters;

        public List<Monster> Monsters
        {
            get
            {
                if (monsters == null)
                {
                    monsters = ReadAllMonsters();
                }
                return monsters;
            }
            private set { monsters = value; }
        }

        public string File { get; set; }

        private CsvReader csvReader;

        public MonsterReader(string file)
        {
            File = file;

            csvReader = new CsvReader(new StreamReader(File));
        }

        public MonsterReader(Stream reader)
        {
            File = null;
            csvReader = new CsvReader(new StreamReader(reader));
        }

        private List<Monster> ReadAllMonsters()
        {
            List<Monster> monsterList;
            try
            {
                monsterList = csvReader.GetRecords<Monster>().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Reading file:");
                Console.WriteLine(ex);
                monsterList = new List<Monster>();
            }
            return monsterList;
        }

        public void CreateMonsterDatabase(IEnumerable<Monster> monsters)
        {
            using (var db = new MonsterContext())
            {
                try
                {
                    db.Database.ExecuteSqlCommand("delete from Monsters");
                    db.SaveChangesAsync();

                    db.Monsters.AddRange(monsters);
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
    }

    public class MonsterContext : DbContext
    {
        public MonsterContext()
            : base("MonsterContext")
        {
        }

        public DbSet<Monster> Monsters { get; set; }
    }
}