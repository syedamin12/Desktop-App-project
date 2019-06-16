using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aptech_Management_System
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        int pw;
        bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
            pw = metroPanel1.Width;
            isCollapsed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           // bunifuTransition1.HideSync(admission_form1);
           // bunifuTransition2.ShowSync(dashBoard1);
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
           // bunifuTransition1.HideSync(dashBoard1);
            //bunifuTransition2.ShowSync(enquree_Form_11);
        }

        private void Header_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                metroPanel1.Width = metroPanel1.Width + 10;
                if (metroPanel1.Width >= pw)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
                else
                {
                    metroPanel1.Width = metroPanel1.Width - 10;
                    if (metroPanel1.Width <= 59)
                    {
                        timer1.Stop();
                        isCollapsed = true;
                        this.Refresh();
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel7_Paint(object sender, PaintEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }

        private void metroLink3_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
           // bunifuTransition1.HideSync(admission_form1);
           // bunifuTransition2.ShowSync(admission_form1);
        }
    }
}
