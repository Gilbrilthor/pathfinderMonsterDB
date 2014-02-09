using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDBParser
{
    internal class TableNameLookup
    {
        private static Dictionary<Type, string> tableNameDict;

        public static string GetTableName<T>() where T : class
        {
            if (tableNameDict == null)
            {
                tableNameDict = buildTableNameDict();
            }

            return tableNameDict[typeof(T)];
        }

        private static Dictionary<Type, string> buildTableNameDict()
        {
            var dTableName = new Dictionary<Type, string>();

            dTableName.Add(typeof(Monster), "Monsters");
            dTableName.Add(typeof(Spell), "Spells");
            dTableName.Add(typeof(Feat), "Feats");
            dTableName.Add(typeof(MagicItem), "MagicItems");
            dTableName.Add(typeof(NPC), "NPCs");

            return dTableName;
        }
    }
}