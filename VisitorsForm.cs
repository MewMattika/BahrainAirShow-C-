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
    public partial class VisitorsForm : Form
    {
        public VisitorsForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        String VisitList;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkBox_Stage.Checked)
            {
                VisitList = "Booths Hall";
                listBox_VisitList.Items.Add(VisitList);
            }

            if (checkBox_Shopping.Checked)
            {
                VisitList = "Shopping Area";
                listBox_VisitList.Items.Add(VisitList);
            }

            if (checkBox_Kids.Checked)
            {
                VisitList = "Kids Area";
                listBox_VisitList.Items.Add(VisitList);
            }

            if (checkBox_Street.Checked)
            {
                VisitList = "Street Perfromers";
                listBox_VisitList.Items.Add(VisitList);
            }

            if (checkBox_Atrraction.Checked)
            {
                VisitList = "Atrraction";
                listBox_VisitList.Items.Add(VisitList);
            }

            if (checkBox_AirCraft.Checked)
            {
                VisitList = "AirCraft Show";
                listBox_VisitList.Items.Add(VisitList);
            }

            //listBox_VisitList.Items.Add(VisitList);//add to visitlist

            //count the listBox_Visitlist Items
            labelTotalOrd.Text = listBox_VisitList.Items.Count.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clear listBox
            listBox_VisitList.Items.Clear();

            //clear textbox
            labelTotalOrd.Text = " ";

            checkBox_AirCraft.Checked = false;
            checkBox_Atrraction.Checked = false;
            checkBox_Kids.Checked = false;
            checkBox_Shopping.Checked = false;
            checkBox_Stage.Checked = false;
            checkBox_Street.Checked = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox_VisitList.SelectedIndex != -1)
            {

                int index = listBox_VisitList.SelectedIndex;
                listBox_VisitList.Items.RemoveAt(index);
            }

            //recalculate totalord
            labelTotalOrd.Text = listBox_VisitList.Items.Count.ToString();


        }

        private void VisitorsForm_Load(object sender, EventArgs e)
        {
        }

        private void button_selectAll_Click(object sender, EventArgs e)
        {
            checkBox_AirCraft.Checked = true;
            checkBox_Atrraction.Checked = true;
            checkBox_Kids.Checked = true;
            checkBox_Shopping.Checked = true;
            checkBox_Stage.Checked = true;
            checkBox_Street.Checked = true;

            listBox_VisitList.Items.Add("Booths Hall");
            listBox_VisitList.Items.Add("Shopping Area");
            listBox_VisitList.Items.Add("Street Performers");
            listBox_VisitList.Items.Add("kids Area");
            listBox_VisitList.Items.Add("Attraction");
            listBox_VisitList.Items.Add("Air Craft");

            labelTotalOrd.Text = listBox_VisitList.Items.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox_AirCraft.Checked = true;
            checkBox_Atrraction.Checked = true;
            checkBox_Kids.Checked = true;
            checkBox_Shopping.Checked = true;
            checkBox_Stage.Checked = true;
            checkBox_Street.Checked = true;

            listBox_VisitList.Items.Add("Booths Hall");
            listBox_VisitList.Items.Add("Shopping Area");
            listBox_VisitList.Items.Add("Street Performers");
            listBox_VisitList.Items.Add("kids Area");
            listBox_VisitList.Items.Add("Attraction");
            listBox_VisitList.Items.Add("Air Craft");

            labelTotalOrd.Text = listBox_VisitList.Items.Count.ToString();
        }

        private void button_Pay_Click(object sender, EventArgs e)
        {
            ProductForm productform = new ProductForm();
            if (checkBox_Stage.Checked)
            {
                productform.ShowDialog();
            }
            else
                MessageBox.Show("You Need to Choose Booths Hall");
        }

        private void VisitorsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
