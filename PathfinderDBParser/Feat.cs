using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderDBParser
{
    public class Feat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Prerequisites { get; set; }

        public string Prerequisite_Feats { get; set; }

        public string Benefit { get; set; }

        public string Normal { get; set; }

        public string Special { get; set; }

        public string Source { get; set; }

        [MaxLength]
        public string Fulltext { get; set; }

        public string Teamwork { get; set; }

        public string Critical { get; set; }

        public string Grit { get; set; }

        public string Style { get; set; }

        public string Performance { get; set; }

        public string Racial { get; set; }

        public string Companion_Familiar { get; set; }

        public string Race_Name { get; set; }

        public string Note { get; set; }

        public string Goal { get; set; }

        public string Completion_Benefit { get; set; }

        public string Multiples { get; set; }

        public string Suggested_Traits { get; set; }
    }
}