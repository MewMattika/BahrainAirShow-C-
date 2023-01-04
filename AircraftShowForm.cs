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
    public partial class AircraftShowForm : Form
    {
        public AircraftShowForm()
        {
            InitializeComponent();
        }

        private void aircraftTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aircraftTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aircraftBDDataSet);

        }

        private void AircraftShowForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aircraftBDDataSet.AircraftTable' table. You can move, or remove it, as needed.
            this.aircraftTableTableAdapter.Fill(this.aircraftBDDataSet.AircraftTable);

            this.AcceptButton = button_ShowImg;

        }

        private void button_ShowImg_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox_SearchID.Text);
            //int id = (int) textBox_SearchID.Text();
            this.aircraftTableTableAdapter.NameSearch(this.aircraftBDDataSet.AircraftTable, id);

            if (id==1)
            {
                pictureBox_Airbus.Visible = true;
                pictureBox_Ilyushin.Visible = false;
                pictureBox_Mitsubishi.Visible = false;
                pictureBox_Boeing.Visible = false;
                pictureBox_adcom.Visible = false;
                pictureBox_aermacchi.Visible = false;
                pictureBox_aero.Visible = false;
                pictureBox_aerospatiale.Visible = false;

            }
            else if (id==2)
            {
                pictureBox_Ilyushin.Visible = true;
                pictureBox_Airbus.Visible = false;
                pictureBox_Mitsubishi.Visible = false;
                pictureBox_Boeing.Visible = false;
                pictureBox_adcom.Visible = false;
                pictureBox_aermacchi.Visible = false;
                pictureBox_aero.Visible = false;
                pictureBox_aerospatiale.Visible = false;
            }
            
            else if (id == 4)
            {
                pictureBox_Mitsubishi.Visible = true;
                pictureBox_Airbus.Visible = false;
                pictureBox_Ilyushin.Visible = false;
                pictureBox_Boeing.Visible = false;
                pictureBox_adcom.Visible = false;
                pictureBox_aermacchi.Visible = false;
                pictureBox_aero.Visible = false;
                pictureBox_aerospatiale.Visible = false;
            }
            else if (id == 5)
            {
                pictureBox_Boeing.Visible = true;
                pictureBox_Airbus.Visible = false;
                pictureBox_Ilyushin.Visible = false;
                pictureBox_Mitsubishi.Visible = false;
                pictureBox_adcom.Visible = false;
                pictureBox_aermacchi.Visible = false;
                pictureBox_aero.Visible = false;
                pictureBox_aerospatiale.Visible = false;
            }
            else if (id == 6)
            {
                pictureBox_adcom.Visible = true;
                pictureBox_Airbus.Visible = false;
                pictureBox_Ilyushin.Visible = false;
                pictureBox_Mitsubishi.Visible = false;
                pictureBox_Boeing.Visible = false;
                pictureBox_aermacchi.Visible = false;
                pictureBox_aero.Visible = false;
                pictureBox_aerospatiale.Visible = false;
            }
            else if (id == 7)
            {
                pictureBox_aermacchi.Visible = true;
                pictureBox_Airbus.Visible = false;
                pictureBox_Ilyushin.Visible = false;
                pictureBox_Mitsubishi.Visible = false;
                pictureBox_Boeing.Visible = false;
                pictureBox_adcom.Visible = false;
                pictureBox_aero.Visible = false;
                pictureBox_aerospatiale.Visible = false;
            }
            else if (id == 8)
            {
                pictureBox_aero.Visible = true;
                pictureBox_Airbus.Visible = false;
                pictureBox_Ilyushin.Visible = false;
                pictureBox_Mitsubishi.Visible = false;
                pictureBox_Boeing.Visible = false;
                pictureBox_adcom.Visible = false;
                pictureBox_aermacchi.Visible = false;
                pictureBox_aerospatiale.Visible = false;
            }
            else if (id == 9)
            {
                pictureBox_aerospatiale.Visible = true;
                pictureBox_Airbus.Visible = false;
                pictureBox_Ilyushin.Visible = false;
                pictureBox_Mitsubishi.Visible = false;
                pictureBox_Boeing.Visible = false;
                pictureBox_adcom.Visible = false;
                pictureBox_aermacchi.Visible = false;
                pictureBox_aero.Visible = false;
            }
        }
    }
}
