using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDBParser
{
    public class SpellReader : Reader<Spell>
    {
        private List<Spell> spells;

        public List<Spell> Spells
        {
            get
            {
                if (spells == null)
                {
                    spells = ReadAll();
                }
                return spells;
            }
            private set { spells = value; }
        }

        public SpellReader(string file)
            : base(file)

        { TableName = "Spells"; }

        public SpellReader(Stream reader)
            : base(reader)
        { TableName = "Spells"; }

        public void CreateSpellDatabase(IEnumerable<Spell> spells)
        {
            CreateDatabase(spells, TableName);
        }

        private string TableName { get; set; }
    }
}