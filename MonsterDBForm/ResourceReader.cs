using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDBForm
{
    internal class ResourceReader
    {
        public static string ReadPFCssFile()
        {
            var output = "";
            var assembly = Assembly.GetExecutingAssembly();

            var nameText = "MonsterDBForm.PF.css";

            using (var stream = assembly.GetManifestResourceStream(nameText))
            {
                using (var reader = new StreamReader(stream))
                {
                    output = reader.ReadToEnd();
                }
            }

            return output;
        }

        public static string ReadHelpFile()
        {
            var output = "";
            var assembly = Assembly.GetExecutingAssembly();

            var nameText = "MonsterDBForm.MonsterDBHelp.html";

            using (var stream = assembly.GetManifestResourceStream(nameText))
            {
                using (var reader = new StreamReader(stream))
                {
                    output = reader.ReadToEnd();
                }
            }

            return output;
        }
    }
}