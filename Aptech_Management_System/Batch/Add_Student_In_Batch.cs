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

namespace Aptech_Management_System.Batch
{
    public partial class Add_Student_In_Batch : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FNN8LEL\\SQLEXPRESS;Initial Catalog=Aptech_Management_Systems;Integrated Security=True");

        public Add_Student_In_Batch()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Add_Student (Do_id,Envolment_no,Name,email,Contact_no,Batch,teacher,Course,Area) values(@Do_id,@Envolment_no,@Name,@email,@Contact_no,@Batch,@teacher,@Course,@Area)", con);
            cmd.Parameters.AddWithValue("@Do_id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Envolment_no", textBox2.Text);
            cmd.Parameters.AddWithValue("@Name", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@Contact_no", textBox5.Text);
            cmd.Parameters.AddWithValue("@Batch", textBox6.Text);
            cmd.Parameters.AddWithValue("@teacher", textBox8.Text);
            cmd.Parameters.AddWithValue("@Course", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Area", textBox8.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("U Have Saccefully");
            con.Close();
        }
    }
}
