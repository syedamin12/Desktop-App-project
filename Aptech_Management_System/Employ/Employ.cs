using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aptech_Management_System.Employ
{
    public partial class Employ : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FNN8LEL\\SQLEXPRESS;Initial Catalog=Aptech_Management_Systems;Integrated Security=True");

        public Employ()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Employ_Add (Dates,Employee_id,F_name,L_name,Emails,Date_join,Refrence,Designation,Department,Is_Active,Profile) values(@Dates,@Employee_id,@F_name,@L_name,@Emails,@Date_join,@Refrence,@Designation,@Department,@Is_Active,@Profile)", con);
            cmd.Parameters.AddWithValue("@Dates", textBox6.Text);
            cmd.Parameters.AddWithValue("@Employee_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@F_name", textBox3.Text);
            cmd.Parameters.AddWithValue("@L_name", textBox4.Text);
            cmd.Parameters.AddWithValue("@Emails", textBox5.Text);
            cmd.Parameters.AddWithValue("@Date_join", textBox2.Text);
            cmd.Parameters.AddWithValue("@Refrence", textBox8.Text);
            cmd.Parameters.AddWithValue("@Designation", textBox8.Text);
            cmd.Parameters.AddWithValue("@Department", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Is_Active", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Profile", metroButton4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("U Have Saccefully");
            con.Close();
        }
    }
}
