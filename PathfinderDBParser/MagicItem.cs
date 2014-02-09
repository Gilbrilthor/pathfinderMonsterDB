using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDBParser
{
    public class MagicItem
    {
        public string Name { get; set; }

        public string Aura { get; set; }

        public string Cl { get; set; }

        public string Slot { get; set; }

        public string Price { get; set; }

        public string Weight { get; set; }

        [MaxLength]
        public string Description { get; set; }

        public string Requirements { get; set; }

        public string Cost { get; set; }

        public string Group { get; set; }

        public string Source { get; set; }

        public string Al { get; set; }

        public string Int { get; set; }

        public string Wis { get; set; }

        public string Cha { get; set; }

        public string Ego { get; set; }

        public string Communication { get; set; }

        public string Senses { get; set; }

        public string Powers { get; set; }

        public string Magicitems { get; set; }

        [MaxLength]
        public string Fulltext { get; set; }

        [MaxLength]
        public string Destruction { get; set; }

        public bool Minorartifactflag { get; set; }

        public bool Majorartifactflag { get; set; }

        public bool Abjuration { get; set; }

        public bool Conjuration { get; set; }

        public bool Divination { get; set; }

        public bool Enchantment { get; set; }

        public bool Evocation { get; set; }

        public bool Necromancy { get; set; }

        public bool Transmutation { get; set; }

        public string Aurastrength { get; set; }

        public string Weightvalue { get; set; }

        public float Pricevalue { get; set; }

        public float Costvalue { get; set; }

        public string Languages { get; set; }

        public string Baseitem { get; set; }

        public string Linktext { get; set; }

        public int Id { get; set; }

        public string Mythic { get; set; }

        public string Legendaryweapon { get; set; }

        public string Illusion { get; set; }

        public string Universal { get; set; }
    }
}