using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFromEmployee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {


            double bs = Convert.ToDouble(Cal_basic.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.20;
            double da = bs * 0.10;
            double pf = bs * 0.12;

            double gross = (bs + hra + ta + da) - pf;

            Cal_Hra.Text = hra.ToString();
            Cal_Ta.Text= ta.ToString();
            cal_Da.Text = da.ToString();
            Cal_salary.Text = da.ToString();
            gross_sal.Text = gross.ToString();

           


        }

        private void Dep_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Showdata_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Emp_name.Text,Emp_id.Text);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "HR", "Admin", "Development", "Testing", "Sales", "Finance", "Marketing" };
            Dep_list.DataSource = list;
        }
    }
}