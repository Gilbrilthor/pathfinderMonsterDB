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
    public partial class InfoBox : Form
    {
        public InfoBox()
        {
            InitializeComponent();
        }

        private void InfoBox_Load(object sender, EventArgs e)
        {
        }

        public void ShowInfoBox(string info)
        {
            infoTextLabel.Text = info;
            this.Show();
        }
    }
}