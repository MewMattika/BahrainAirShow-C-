using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BahrainAirshow
{
    public partial class Beginning : Form
    {
        public Beginning()
        {
            InitializeComponent();
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            EntryForm entry = new EntryForm();
            entry.ShowDialog();
        }

        private void Beginning_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
    }
}
