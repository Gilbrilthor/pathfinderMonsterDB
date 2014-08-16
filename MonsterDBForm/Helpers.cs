using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterDBForm
{
    internal static class Helpers
    {
        public static void ExportToCSV(this DataGridView view, string pathToSave, string delimiter = ",")
        {
            // Create a file for writing out
            using (var fileOut = File.CreateText(pathToSave))
            {
                // Write the headers
                for (int i = 0; i < view.ColumnCount; i++)
                {
                    fileOut.Write(@"""{0}""{1}", view.Columns[i].Name, delimiter);
                }
                // Write a new line
                fileOut.WriteLine();
                // Write the data
                for (int rowIndex = 0; rowIndex < view.RowCount; rowIndex++)
                {
                    // Get the current row
                    var row = view.Rows[rowIndex];

                    // Copy all the cells' values
                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        fileOut.Write(@"""{0}""{1}", row.Cells[cellIndex].Value, delimiter);
                    }
                    // End it with a newline
                    fileOut.WriteLine();
                }
            }
        }
    }
}