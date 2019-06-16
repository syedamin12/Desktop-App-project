using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aptech_Management_System
{

    public partial class Login :MetroFramework.Forms.MetroForm
    {

        DataSet ds = new DataSet();

        DataSet bs = new DataSet();

        public Login()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.Equals("") && textBox1.Text == "")
            {
                MessageBox.Show("You can not Login Without Selected Username or Password");
            }
            else
                if (comboBox1.SelectedItem.Equals(""))
                {
                    MessageBox.Show("Please Select username....");
                }
                else
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Please Enter Correct Password....");
                    }

            pictureBox1.BringToFront();

            this.bunifuButton1.Hide();
            string comb;
            comb = comboBox1.SelectedItem.ToString();
            String pass;
            pass = textBox1.Text.ToString();






        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            this.metroLink2.Hide();
            textBox1.UseSystemPasswordChar = true;
            metroLink1.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            metroLink1.Hide();
            metroLink2.Show();

            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           

        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void signsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        }
    
}
