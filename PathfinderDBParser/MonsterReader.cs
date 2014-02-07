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
    public class MonsterReader : Reader<Monster>
    {
        private List<Monster> monsters;

        public List<Monster> Monsters
        {
            get
            {
                if (monsters == null)
                {
                    monsters = ReadAll();
                }
                return monsters;
            }
            private set { monsters = value; }
        }

        public MonsterReader(string file)
            : base(file)
        { }

        public MonsterReader(Stream reader)
            : base(reader)
        { }

        public void CreateMonsterDatabase(IEnumerable<Monster> monsters)
        {
            CreateDatabase(monsters, TableName);
        }

        private string TableName { get; set; }
    }
}