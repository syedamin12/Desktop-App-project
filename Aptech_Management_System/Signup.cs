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
    public partial class Signup : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FNN8LEL\\SQLEXPRESS;Initial Catalog=Aptech_Management_Systems;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adp = new SqlDataAdapter();
        SqlDataAdapter bdp = new SqlDataAdapter();

        DataSet ds = new DataSet();

        DataSet bs = new DataSet();
        public Signup()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Insert Field");
            }else
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("Insert Field");
                }else
                    if (textBox1.Text == "" && textBox2.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Insert Field");
            }else
                        if (textBox1.Text == ""  && textBox2.Text == "" && textBox4.Text == "")
                        {
                            MessageBox.Show("Insert Field");
                        }else
                            if (textBox2.Text == "" && textBox1.Text == "" && textBox4.Text == "")
                            {
                                MessageBox.Show("Insert Field");
                            }
            else
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Insert Field");
                }
                else
                    if (textBox2.Text == "" && textBox4.Text == "")
                    {
                        MessageBox.Show("Insert Field");
                    }
                    else
                        if (textBox2.Text == "" && textBox3.Text == "")
                        {
                            MessageBox.Show("Insert Field");
                        }else
                            if (textBox1.Text == "" && textBox4.Text == "")
                            {
                                MessageBox.Show("Insert Field");
                            }
            else

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter User Name......");
            }
            else
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Password.....");
                }
                else
                    if (textBox3.Text == "")
                    {
                        MessageBox.Show("Please Enter Confrm Password");
                    }
                    else

                        if (textBox4.Text == "")
                        {
                            MessageBox.Show("Please Enter Email Adress");

                        }

                        else
                        {
                            try
                            {
                                string user, emai, pass, conf;
                                user = textBox1.Text;
                                emai = textBox4.Text;
                                pass = textBox2.Text;
                                conf = textBox3.Text;
                                con.Open();
                                cmd.Connection = con;
                                cmd.CommandText = "Insert into Login(User_names,Emails,Password,Conform) VALUES('" + user + "','" + emai + "','" + pass + "','" + conf + "')";
                                cmd.ExecuteNonQuery();
                                con.Close();
                                Login c = new Login();
                                c.Show();

                            }

                            catch (SqlException ex)
                            {
                                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


        }

        private void metroLink4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}