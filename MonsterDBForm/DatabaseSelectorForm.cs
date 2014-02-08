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
    public partial class DatabaseSelectorForm : Form
    {
        public DatabaseSelectorForm(IEnumerable<Reader<object>> readers)
        {
            InitializeComponent();

            readerCheckList.Items.AddRange(readers.ToArray<object>());
        }

        private void DatabaseSelectorForm_Load(object sender, EventArgs e)
        {
        }
    }
}