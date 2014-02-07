using PathfinderDBParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterDBForm
{
    public partial class SimpleForm : Form
    {
        public SimpleForm()
        {
            InitializeComponent();
            backend = new MonsterDBFormBackend();
        }

        private MonsterDBFormBackend backend;

        private void SimpleForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            openDialog.Filter = "SqlCompact Files (*.sdf)|*.sdf";
            openDialog.CheckFileExists = true;

            openDialog.DefaultExt = ".sdf";

            if (openDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                backend.SetDatabaseFilePath(openDialog.FileName);
                backend.ExecuteQuery("select * from monsters");

                var columnNames = backend.RetrieveColumnNamesFromDatabase().ToArray();
                selectListBox.Items.Clear();
                selectListBox.Items.AddRange(columnNames);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder("Select ");

            foreach (var item in selectListBox.SelectedItems)
            {
                sb.AppendFormat("{0},", item);
            }

            // Remove the end comma
            sb.Remove(sb.Length - 1, 1);

            sb.Append(" From Monsters");

            try
            {
                var results = backend.ExecuteQuery(sb.ToString());

                resultsGridView.DataSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            where1Combo.Items.Clear();
            if (selectListBox.SelectedItems.Count > 0)
            {
                where1Combo.Items.AddRange(selectListBox.SelectedItems.Cast<string>().ToArray());
            }
        }
    }
}