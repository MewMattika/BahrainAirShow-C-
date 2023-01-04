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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            OrganizersForm organizers = new OrganizersForm();
            ExhibitorsForm exhibitors = new ExhibitorsForm();
            VisitorsForm visitors = new VisitorsForm();
            AccessForm accessform = new AccessForm();

            if (radioButton_Exhibitors.Checked)
            {
                exhibitors.ShowDialog();
                //this.Close();
            }
            else if (radioButton_Organizers.Checked)
                //organizers.ShowDialog();
                accessform.ShowDialog();
            else if (radioButton_Visitors.Checked)
                visitors.ShowDialog();
        }

        private void radioButton_Exhibitors_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button_Next;
        }
    }
}
