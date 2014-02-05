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
    public partial class HelpForm : Form
    {
        public HelpForm(string helpHtml = null)
        {
            InitializeComponent();
            helpBrowser.DocumentText = helpHtml;
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
        }

        private void HelpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }
    }
}