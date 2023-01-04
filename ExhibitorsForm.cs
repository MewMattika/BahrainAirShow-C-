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
    public partial class ExhibitorsForm : Form
    {
        public ExhibitorsForm()
        {
            InitializeComponent();
        }

        private void ExhibitorsForm_Load(object sender, EventArgs e)
        {
           // this.BackColor = Color.DarkGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Description.Text = "";
        }

        private void radioButton_LBooth_CheckedChanged(object sender, EventArgs e)
        {
            /*if (radioButton_LBooth.Checked)
                textBox_Description.Text = "Large Booth Description: \n";*/
        }

        private void textBox_Description_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_MBooth_CheckedChanged(object sender, EventArgs e)
        {
               /* if (radioButton_MBooth.Checked)
                textBox_Description.Text = "Medium Booth Description: \n";*/
        }

        private void radioButton_SBooth_CheckedChanged(object sender, EventArgs e)
        {
            /*if (radioButton_SBooth.Checked)
                textBox_Description.Text = "Small Booth Description: \n";*/
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            /*ProductForm productF = new ProductForm();
            if (radioButton_LBooth.Checked)
            {
                productF.label_BoothChoosen.Text = "Large Booth";
                productF.ShowDialog();
            }
            else if ( radioButton_MBooth.Checked)
            {
                productF.label_BoothChoosen.Text = "Medium Booth";
                productF.ShowDialog();
            }
            else if (radioButton_SBooth.Checked)
            {
                productF.label_BoothChoosen.Text = "Small Booth";
                productF.ShowDialog();
            }
            else if (radioButton_CornerBooth.Checked)
            {
                productF.label_BoothChoosen.Text = "Corner Booth";
                productF.ShowDialog();
            }
            else
                MessageBox.Show("Select a Booth First Please! ");*/
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            AircraftShowForm aircraftshow = new AircraftShowForm();
            aircraftshow.ShowDialog();
        }

        private void button_Done_Click(object sender, EventArgs e)
        {
            if (radioButton_CornerBooth.Checked)
            {
                MessageBox.Show("Corner Booth Reserved For You! \n\n You can visit the location and arrange your Products.");
                radioButton_CornerBooth.Enabled = false;
                radioButton_LBooth.Enabled = false;
                radioButton_MBooth.Enabled = false;
                radioButton_SBooth.Enabled = false;
            }
            if (radioButton_LBooth.Checked)
            {
                MessageBox.Show("Large Booth Reserved For You! \n\n You can visit the location and arrange your Products.");
                radioButton_CornerBooth.Enabled = false;
                radioButton_LBooth.Enabled = false;
                radioButton_MBooth.Enabled = false;
                radioButton_SBooth.Enabled = false;
            }
            if (radioButton_MBooth.Checked)
            {
                MessageBox.Show("Medium Booth Reserved For You! \n\n You can visit the location and arrange your Products.");
                radioButton_CornerBooth.Enabled = false;
                radioButton_LBooth.Enabled = false;
                radioButton_MBooth.Enabled = false;
                radioButton_SBooth.Enabled = false;
            }
            if (radioButton_SBooth.Checked)
            {
                MessageBox.Show("Small Booth Reserved For You! \n\n You can visit the location and arrange your Products.");
                radioButton_CornerBooth.Enabled = false;
                radioButton_LBooth.Enabled = false;
                radioButton_MBooth.Enabled = false;
                radioButton_SBooth.Enabled = false;
            }
            if (radioButton_CornerBooth.Checked==false && radioButton_LBooth.Checked==false && radioButton_MBooth.Checked==false && radioButton_SBooth.Checked==false)
            {
                MessageBox.Show("Please Select a Booth First!");
            }
        }
    }
}
