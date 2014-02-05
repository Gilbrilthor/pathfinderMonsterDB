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
    public partial class StatBlockViewer : Form
    {
        public StatBlockViewer()
        {
            InitializeComponent();
        }

        public void setDocumentText(string text, string name = null)
        {
            webBrowser1.DocumentText = text;

            if (name != null)
            {
                this.Text = name;
            }
        }

        private void StatBlockViewer_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = "<p> No data received. Choose a row that has fulltext to display the stat block. </p>";
        }

        private void StatBlockViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }
    }
}