using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDBParser
{
    public class Monster
    {
        public string Name { get; set; }

        public string CR { get; set; }

        public int XP { get; set; }

        public string Race { get; set; }

        public string Class { get; set; }

        public string MonsterSource { get; set; }

        public string Alignment { get; set; }

        public string Size { get; set; }

        public string Type { get; set; }

        public string SubType { get; set; }

        public string AC { get; set; }

        public int HP { get; set; }

        public string HD { get; set; }

        public string Saves { get; set; }

        public string Fort { get; set; }

        public string Ref { get; set; }

        public string Will { get; set; }

        public string Speed { get; set; }

        public string Melee { get; set; }

        public string Ranged { get; set; }

        public string Space { get; set; }

        public string Reach { get; set; }

        public string AbilityScores { get; set; }

        public string Feats { get; set; }

        public string Skills { get; set; }

        public string RacialMods { get; set; }

        public string Languages { get; set; }

        public string SQ { get; set; }

        public string Environment { get; set; }

        public string Organization { get; set; }

        public string Treasure { get; set; }

        public string Group { get; set; }

        public string Source { get; set; }

        public bool IsTemplate { get; set; }

        [MaxLength]
        public string FullText { get; set; }

        public string Gear { get; set; }

        public string OtherGear { get; set; }

        public bool CharacterFlag { get; set; }

        public bool CompanionFlag { get; set; }

        public int Fly { get; set; }

        public int Climb { get; set; }

        public int Burrow { get; set; }

        public int Swim { get; set; }

        public int Land { get; set; }

        public string TemplatesApplied { get; set; }

        public string AgeCategory { get; set; }

        public bool DontUseRacialHD { get; set; }

        public string VariantParent { get; set; }

        public string ClassArchetypes { get; set; }

        public string CompanionFamiliarLink { get; set; }

        public string AlternateNameForm { get; set; }

        public int id { get; set; }

        public int UniqueMonster { get; set; }

        public int MR { get; set; }

        public bool Mythic { get; set; }

        public int MT { get; set; }
    }
}