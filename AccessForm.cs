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
    public partial class AccessForm : Form
    {
        static int attempt = 3;

        public AccessForm()
        {
            InitializeComponent();
        }

        private void button_AccessExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //refrence:  https://www.c-sharpcorner.com/article/creating-login-form-with-authentication-for/

        private void button_logIn_Click(object sender, EventArgs e)
        {
            string username = textBox_UserName.Text;
            string password = textBox_Pass.Text;
            OrganizersForm organizers = new OrganizersForm();

                textBox_Pass.PasswordChar = '*';
            if ((this.textBox_UserName.Text == "Admin") && (this.textBox_Pass.Text == "admin"))
            {
                attempt = 0;
                pictureBox_LogIn.Visible = false;
                pictureBox_Granted.Visible = true;
                MessageBox.Show("you are granted with access");
                organizers.ShowDialog();
                this.Close();


            }
            else if ((attempt == 3) && (attempt > 0))
            {
                label_Attempts.Text = ("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                --attempt;
            }
            else
            {
                pictureBox_LogIn.Visible = false;
                pictureBox_Denied.Visible = true;
                MessageBox.Show("you are not granted with access");
            }

        }

        private void AccessForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button_logIn;
        }
    }
 }

