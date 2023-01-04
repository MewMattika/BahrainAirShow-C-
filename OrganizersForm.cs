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
    public partial class OrganizersForm : Form
    {
        public OrganizersForm()
        {
            InitializeComponent();
        }

        ExhibitorsForm exhibitor = new ExhibitorsForm();

        private void groupBox_Size_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_ToAdd_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_Hall_CheckedChanged(object sender, EventArgs e)
        {
           /* if (checkBox_Hall.Checked)
            {
                groupBox_Size.Visible = true;
                groupBox_boothSize.Visible = false;
            }*/
        }

        private void checkBox_Booth_CheckedChanged(object sender, EventArgs e)
        {
           /* if (checkBox_Booth.Checked)
            {
                groupBox_boothSize.Visible = true;
                groupBox_Size.Visible = false;
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_LargeB_CheckedChanged(object sender, EventArgs e)
        {
           // if (radioButton_LargeB.Checked)
             //   exhibitor.radioButton_LBooth.Visible = true;
        }

        String Choosen, date, time, show; 

        private void button_Done_Click(object sender, EventArgs e)
        {
            if (checkBox_A_AreaH.Checked)
            {
                Choosen = "A";
            }

            if (checkBox_B_AreaH.Checked)
            {
                Choosen = Choosen+" B";
            }

            if (checkBox_C_AreaH.Checked)
            {
                Choosen = Choosen + " C";
            }

            if (checkBox_D_AreaH.Checked)
            {
                Choosen = Choosen + " D";
            }

            if (checkBox_E_AreaH.Checked)
            {
                Choosen = Choosen + " E";
            }

            if (checkBox_F_AreaH.Checked)
            {
                Choosen = Choosen + " F";
            }

            if (checkBox_G_AreaH.Checked)
            {
                Choosen = Choosen + " G";
            }

            if (checkBox_H_AreaH.Checked)
            {
                Choosen = Choosen + " H";
            }

            if (checkBox_P_AreaH.Checked)
            {
                Choosen = Choosen + " P";
            }

            if (radioButton_Jan1.Checked)
            {
                date = radioButton_Jan1.Text;
            }

            if (radioButton_Jan2.Checked)
            {
                date = radioButton_Jan2.Text;
            }

            if (radioButton_Jan3.Checked)
            {
                date = radioButton_Jan3.Text;
            }

            if (radioButton_Morning.Checked)
            {
                time = radioButton_Morning.Text;
            }
            if (radioButton_AfterNoon.Checked)
            {
                time = radioButton_AfterNoon.Text;
            }
            if (radioButton_Commercial.Checked)
            {
                show = radioButton_Commercial.Text;
            }
            if (radioButton_Military.Checked)
            {
                show = radioButton_Military.Text;
            }
            MessageBox.Show("You've Add " + Choosen + " Areas \n\n Date: " + date + "\n\n Time: " + time + "\n\n Show: " + show);
            this.Close();
        }
    }
}
