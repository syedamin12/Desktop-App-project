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

namespace Aptech_Management_System.Accountant
{
    public partial class Resiept : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FNN8LEL\\SQLEXPRESS;Initial Catalog=Aptech_Management_Systems;Integrated Security=True");
        public Resiept()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Fees_(Resip_no,Stu_id,batch,Name,title,comments,Amount,Panalty,Team,ov_amount,Total)values(@Resip_no,@Stu_id,@batch,@Name,@title,@comments,@Amount,@Panalty,@Team,@ov_amount,@Total)", con);
            cmd.Parameters.AddWithValue("@Resip_no", metroTextBox1.Text);
            cmd.Parameters.AddWithValue("@Stu_id", metroTextBox2.Text);
            cmd.Parameters.AddWithValue("@batch", metroTextBox3.Text);
            cmd.Parameters.AddWithValue("@Name", metroTextBox4.Text);
            cmd.Parameters.AddWithValue("@title", metroTextBox5.Text);
            cmd.Parameters.AddWithValue("@comments", metroTextBox6.Text);
            cmd.Parameters.AddWithValue("@Amount", metroTextBox13.Text);
            cmd.Parameters.AddWithValue("@Panalty", metroTextBox8.Text);
            cmd.Parameters.AddWithValue("@Team", metroTextBox11.Text);
            cmd.Parameters.AddWithValue("@ov_amount", metroTextBox12.Text);
            cmd.Parameters.AddWithValue("@Total", metroTextBox15.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("U Have Saccefully");
            con.Close();
        }

        private void Resiept_Load(object sender, EventArgs e)
        {

        }
    }
}
