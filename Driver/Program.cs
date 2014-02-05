using PathfinderDBParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driver
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var filePath = @"D:\Users\Matthew\Google Drive\D&D\Monster Database.csv";

            var parser = new MonsterReader(filePath);

            Console.WriteLine("Reading...");
            List<Monster> monsterList = parser.Monsters;
            Console.WriteLine("Done!");

            //var propertyList = typeof(Monster).GetProperties();

            //foreach (var property in propertyList)
            //{
            //    Console.WriteLine("Property Name: " + property.Name);
            //    List<Type> listType = enumerateTypes(monsterList, property);

            //    foreach (var type in listType)
            //    {
            //        Console.WriteLine("\t" + type);
            //    }
            //}

            //Console.WriteLine("Finished looking through the properties!");

            Console.WriteLine();
            var isTemplateValues = (from m in monsterList
                                    select m.IsTemplate).Distinct();
            foreach (var item in isTemplateValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var CharacterFlagValues = (from m in monsterList
                                       select m.CharacterFlag).Distinct();
            foreach (var item in CharacterFlagValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var CompanionFlagValues = (from m in monsterList
                                       select m.CompanionFlag).Distinct();
            foreach (var item in CompanionFlagValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var DontUseRacialHDValues = (from m in monsterList
                                         select m.DontUseRacialHD).Distinct();
            foreach (var item in DontUseRacialHDValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var MRValues = (from m in monsterList
                            select m.MR).Distinct();
            foreach (var item in MRValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var MythicValues = (from m in monsterList
                                select m.Mythic).Distinct();
            foreach (var item in MythicValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            var MTValues = (from m in monsterList
                            select m.MT).Distinct();
            foreach (var item in MTValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        private static List<Type> enumerateTypes(List<Monster> monsterList, System.Reflection.PropertyInfo property)
        {
            bool notInt = false, notDouble = false;
            var typeSet = new HashSet<Type>();

            foreach (var monster in monsterList)
            {
                // Get the value
                var data = property.GetValue(monster);

                // Check what it can convert to
                try
                {
                    var convertedData = Convert.ChangeType(data, typeof(int));
                    typeSet.Add(typeof(int));
                }
                catch (Exception)
                {
                    notInt = true;
                }
                try
                {
                    var convertedData = Convert.ChangeType(data, typeof(double));
                    typeSet.Add(typeof(double));
                }
                catch (Exception)
                {
                    notDouble = true;
                }
            }

            if (notInt && typeSet.Contains(typeof(int)))
            {
                Console.WriteLine("Not all are Ints!");
            }

            if (notDouble && typeSet.Contains(typeof(double)))
            {
                Console.WriteLine("Not all are Double!");
            }

            return typeSet.ToList();
        }

        private static T ReadTString<T>(string s)
        {
            var foo = TypeDescriptor.GetConverter(typeof(Type));
            return (T)(foo.ConvertFromInvariantString(s));
        }
    }
}