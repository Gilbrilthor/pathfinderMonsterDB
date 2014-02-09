using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDBParser
{
    public class Spell
    {
        public string Name { get; set; }

        public string School { get; set; }

        public string Subschool { get; set; }

        public string Descriptor { get; set; }

        public string Spell_Level { get; set; }

        public string Casting_Time { get; set; }

        public string Components { get; set; }

        public string Costly_Components { get; set; }

        public string Range { get; set; }

        public string Area { get; set; }

        public string Effect { get; set; }

        public string Targets { get; set; }

        public string Duration { get; set; }

        public string Dismissible { get; set; }

        public string Shapeable { get; set; }

        public string Saving_Throw { get; set; }

        public string Spell_Resistence { get; set; }

        [MaxLength]
        public string Description { get; set; }

        [MaxLength]
        public string Description_Formated { get; set; }

        public string Source { get; set; }

        [MaxLength]
        public string Full_Text { get; set; }

        public string Verbal { get; set; }

        public string Somatic { get; set; }

        public string Material { get; set; }

        public string Focus { get; set; }

        public string Divine_Focus { get; set; }

        public string Sor { get; set; }

        public string Wiz { get; set; }

        public string Cleric { get; set; }

        public string Druid { get; set; }

        public string Ranger { get; set; }

        public string Bard { get; set; }

        public string Paladin { get; set; }

        public string Alchemist { get; set; }

        public string Summoner { get; set; }

        public string Witch { get; set; }

        public string Inquisitor { get; set; }

        public string Oracle { get; set; }

        public string Antipaladin { get; set; }

        public string Magus { get; set; }

        public string Adept { get; set; }

        public string Deity { get; set; }

        public string Sla_Level { get; set; }

        public string Domain { get; set; }

        public string Short_Description { get; set; }

        public string Acid { get; set; }

        public string Air { get; set; }

        public string Chaotic { get; set; }

        public string Cold { get; set; }

        public string Curse { get; set; }

        public string Darkness { get; set; }

        public string Death { get; set; }

        public string Disease { get; set; }

        public string Earth { get; set; }

        public string Electricity { get; set; }

        public string Emotion { get; set; }

        public string Evil { get; set; }

        public string Fear { get; set; }

        public string Fire { get; set; }

        public string Force { get; set; }

        public string Good { get; set; }

        public string Language_Dependent { get; set; }

        public string Lawful { get; set; }

        public string Light { get; set; }

        public string Mind_Affecting { get; set; }

        public string Pain { get; set; }

        public string Poison { get; set; }

        public string Shadow { get; set; }

        public string Sonic { get; set; }

        public string Water { get; set; }

        public string Linktext { get; set; }

        public int Id { get; set; }

        public string Material_Costs { get; set; }

        public string Bloodline { get; set; }

        public string Patron { get; set; }

        public string Mythic_Text { get; set; }

        public string Augmented { get; set; }

        public string Mythic { get; set; }
    }
}