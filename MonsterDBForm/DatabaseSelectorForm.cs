﻿using PathfinderDBParser;
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
    public partial class DatabaseSelectorForm : Form
    {
        public DatabaseSelectorForm()
        {
            InitializeComponent();
        }

        private void DatabaseSelectorForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mFile = null, sFile = null;

            Reader<Monster> mReader = null;
            Reader<Spell> sReader = null;

            // See where they want to pull the data from
            if (monsterCheckBox.Checked)
            {
                mFile = getCSVFile("Where is the Monster CSV file?");
                if (mFile != null)
                {
                    mReader = new Reader<Monster>(mFile);
                }
            }
            if (spellCheckBox.Checked)
            {
                sFile = getCSVFile("Where is the Spell CSV file?");
                if (sFile != null)
                {
                    sReader = new Reader<Spell>(sFile);
                }
            }

            // If there is any data they want to use, create the database
            if (mReader != null || sReader != null)
            {
                var saveLoc = getDBSaveLocation("Where do you want to save the database at?");

                AppDomain.CurrentDomain.SetData("DataDirectory", saveLoc);

                if (mReader != null)
                    mReader.CreateDatabase(mReader.Items);

                if (sReader != null)
                    sReader.CreateDatabase(sReader.Items);
            }
            else
            {
                // Display error and try again
                MessageBox.Show("You must select at least one valid .csv file", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
            }

            this.Visible = false;
            this.Close();
        }

        private string getCSVFile(string title)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Comma Separated Values (*.csv)|*.csv";

            dialog.Title = title;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dialog.FileName;
            }
            else return null;
        }

        private string getDBSaveLocation(string title)
        {
            var saveDialog = new SaveFileDialog();

            saveDialog.Filter = "SqlCompact Files (*.sdf)|*.sdf";
            saveDialog.OverwritePrompt = true;

            saveDialog.Title = title;

            saveDialog.DefaultExt = ".sdf";

            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return saveDialog.FileName;
            }

            return null;
        }
    }
}