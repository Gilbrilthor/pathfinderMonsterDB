using PathfinderDBParser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterDBForm
{
    internal class MonsterDBFormBackend
    {
        public DataTable ExecuteQuery(string query)
        {
            var connection = System.Configuration.ConfigurationManager.ConnectionStrings["MonsterContext"];
            SqlCeException exception = null;

            DataTable results = new DataTable();

            using (var conn = new SqlCeConnection(connection.ConnectionString))
            {
                using (var command = new SqlCeCommand(query, conn))
                {
                    using (var dataAdapter = new SqlCeDataAdapter(command))
                    {
                        try
                        {
                            dataAdapter.Fill(results);
                        }
                        catch (SqlCeException ex)
                        {
                            exception = ex;
                        }
                    }
                }
            }

            if (exception != null)
            {
                throw exception;
            }

            return results;
        }

        public void SaveDataAsDatabase(IEnumerable<Monster> monsterList, string location)
        {
            SetDatabaseFilePath(location);

            MonsterReader.CreateMonsterDatabase(monsterList);
        }

        public void SetDatabaseFilePath(string filePath)
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", filePath);
        }

        public void CreateDatabaseFromCSV(string openFilePath, string saveFilePath)
        {
            Stream inFile = new StreamReader(openFilePath).BaseStream;
            var parser = new MonsterReader(inFile);
            SaveDataAsDatabase(parser.Monsters, saveFilePath);
        }

        public IEnumerable<string> RetrieveColumnNamesFromDatabase()
        {
            var result = ExecuteQuery("select column_name from information_schema.columns where table_name = 'monsters'");
            var columnNames = (from row in result.AsEnumerable()
                               select row.ItemArray.First()).Cast<string>();
            return columnNames;
        }
    }
}