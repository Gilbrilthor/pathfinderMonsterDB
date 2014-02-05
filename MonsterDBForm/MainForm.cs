using PathfinderDBParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterDBForm
{
    // Icon for project found at : http://www.iconarchive.com/show/monsters-icons-by-tanitakawkaw/monster-icon.html
    public partial class MainForm : Form
    {
        private MonsterReader parser;

        private StatBlockViewer viewer;

        public MainForm()
        {
            InitializeComponent();

            viewer = new StatBlockViewer();
            helpForm = new HelpForm(ResourceReader.ReadHelpFile());
            backend = new MonsterDBFormBackend();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_PathfinderDBParser_MonsterContextDataSet.Monsters' table. You can move, or remove it, as needed.
            //this.monstersTableAdapter.Fill(this._PathfinderDBParser_MonsterContextDataSet.Monsters);
            //executeQuery("select * from monsters");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog();

            openDialog.Filter = "SqlCompact Files (*.sdf)|*.sdf";
            openDialog.CheckFileExists = true;

            openDialog.DefaultExt = ".sdf";

            if (openDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                backend.SetDatabaseFilePath(openDialog.FileName);
                queryTextBox.Text = "select * from monsters";
                executeQuery("select * from monsters");
                openBlockViewerToolStripMenuItem.Enabled = true;
            }
        }

        private void setDataSource(List<Monster> monsterList)
        {
            resultsGridView.DataSource = monsterList;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            executeQuery(queryTextBox.Text);
        }

        private MonsterDBFormBackend backend;

        private void executeQuery(string query)
        {
            try
            {
                var results = backend.ExecuteQuery(query);
                resultsGridView.DataSource = results;
            }
            catch (SqlCeException ex)
            {
                MessageBox.Show(ex.Message, "An SQL Error Occurred!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveDataAsDatabase(IEnumerable<Monster> monsterList, string location)
        {
            var waitBox = new InfoBox();
            waitBox.ShowInfoBox("Please wait while the database is created...");
            Cursor = Cursors.WaitCursor;

            backend.SaveDataAsDatabase(monsterList, location);

            waitBox.Visible = false;
            waitBox.Dispose();
            Cursor = Cursors.Default;
            openBlockViewerToolStripMenuItem.Enabled = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                executeQuery(queryTextBox.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (resultsGridView.Columns.Contains("FullText") && resultsGridView.SelectedRows.Count > 0)
            {
                var row = resultsGridView.SelectedRows[0];
                var text = row.Cells["FullText"].Value as string;
                var name = row.Cells["Name"].Value as string;

                var pfCssText = ResourceReader.ReadPFCssFile();

                viewer.setDocumentText(pfCssText + Environment.NewLine + text, name);
                openBlockViewerToolStripMenuItem.Enabled = true;
            }
        }

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Pick both the file to open and the name to save the file as
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma Separated Values Files (*.csv)|*.csv";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var saveDialog = new SaveFileDialog();

                saveDialog.Filter = "SqlCompact Files (*.sdf)|*.sdf";
                saveDialog.OverwritePrompt = true;

                saveDialog.DefaultExt = ".sdf";

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    backend.CreateDatabaseFromCSV(dialog.FileName, saveDialog.FileName);
                    parser = new MonsterReader(dialog.OpenFile());
                    saveDataAsDatabase(parser.Monsters, saveDialog.FileName);
                    setDataSource(parser.Monsters);
                }
            }
        }

        private void openBlockViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewer.Show();
            viewer.Focus();
        }

        private HelpForm helpForm;

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpForm.Show();
            helpForm.Focus();
        }
    }
}