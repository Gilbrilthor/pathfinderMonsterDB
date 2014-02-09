using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDBParser
{
    public class NPC
    {
        public string Name { get; set; }

        public string Cr { get; set; }

        public string Xp { get; set; }

        public string Race { get; set; }

        public string Class { get; set; }

        public string Monstersource { get; set; }

        public string Alignment { get; set; }

        public string Size { get; set; }

        public string Type { get; set; }

        public string Subtype { get; set; }

        public string Init { get; set; }

        public string Senses { get; set; }

        public string Aura { get; set; }

        public string Ac { get; set; }

        public string Ac_Mods { get; set; }

        public string Hp { get; set; }

        public string Hd { get; set; }

        public string Hp_Mods { get; set; }

        public string Saves { get; set; }

        public string Fort { get; set; }

        public string Ref { get; set; }

        public string Will { get; set; }

        public string Save_Mods { get; set; }

        public string Defensiveabilities { get; set; }

        public string Dr { get; set; }

        public string Immune { get; set; }

        public string Resist { get; set; }

        public string Sr { get; set; }

        public string Weaknesses { get; set; }

        public string Speed { get; set; }

        public string Speed_Mod { get; set; }

        public string Melee { get; set; }

        public string Ranged { get; set; }

        public string Space { get; set; }

        public string Reach { get; set; }

        public string Specialattacks { get; set; }

        [MaxLength]
        public string Spelllikeabilities { get; set; }

        public string Spellsknown { get; set; }

        public string Spellsprepared { get; set; }

        public string Spelldomains { get; set; }

        public string Abilityscores { get; set; }

        public string Abilityscore_Mods { get; set; }

        public string Baseatk { get; set; }

        public string Cmb { get; set; }

        public string Cmd { get; set; }

        public string Feats { get; set; }

        public string Skills { get; set; }

        public string Racialmods { get; set; }

        public string Languages { get; set; }

        public string Sq { get; set; }

        public string Environment { get; set; }

        public string Organization { get; set; }

        public string Treasure { get; set; }

        [MaxLength]
        public string Description_Visual { get; set; }

        public string Group { get; set; }

        public string Source { get; set; }

        public bool Istemplate { get; set; }

        [MaxLength]
        public string Specialabilities { get; set; }

        [MaxLength]
        public string Description { get; set; }

        [MaxLength]
        public string Fulltext { get; set; }

        public string Gender { get; set; }

        public string Bloodline { get; set; }

        public string Prohibitedschools { get; set; }

        public string Beforecombat { get; set; }

        public string Duringcombat { get; set; }

        public string Morale { get; set; }

        public string Gear { get; set; }

        public string Othergear { get; set; }

        public string Vulnerability { get; set; }

        public string Note { get; set; }

        public bool Characterflag { get; set; }

        public bool Companionflag { get; set; }

        public bool Fly { get; set; }

        public bool Climb { get; set; }

        public bool Burrow { get; set; }

        public bool Swim { get; set; }

        public bool Land { get; set; }

        public string Templatesapplied { get; set; }

        public string Offensenote { get; set; }

        public string Basestatistics { get; set; }

        public string Extractsprepared { get; set; }

        public string Agecategory { get; set; }

        public string Mystery { get; set; }

        public string Classarchetypes { get; set; }

        public string Patron { get; set; }

        public string Companionfamiliarlink { get; set; }

        public string Focusedschool { get; set; }

        public string Traits { get; set; }

        public string Alternatenameform { get; set; }

        public string Linktext { get; set; }

        public int Id { get; set; }

        public bool Uniquemonster { get; set; }

        public string Thassilonianspecialization { get; set; }

        public bool Variant { get; set; }

        public string Mr { get; set; }

        public bool Mythic { get; set; }

        public string Mt { get; set; }
    }
}