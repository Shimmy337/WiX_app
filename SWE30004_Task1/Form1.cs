using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;
using TQBF;

namespace SWE30004_Task1
{
    public partial class Form1 : Form
    {
        private int count = 0;
        calculation calc = new calculation();
        tqbf otherDLL = new tqbf();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "This application is a test application made by Michael Shim 7657161 from Swinburne University.";
        }

        private void btn_intro_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Welcome to a very basic application made in C#. Click on the buttons below!";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            count += 1;
            textBox1.Text = "Current count:" + count.ToString();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            count = 0;
            textBox1.Text = "Current count:" + count.ToString();
        }

        private void btn_calc_add_Click(object sender, EventArgs e)
        {
            try
            {
                int i = calc.Addition(int.Parse(txtbox_calc1.Text), int.Parse(txtbox_calc2.Text));
                txtbox_calc_result.Text = i.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_calc_sub_Click(object sender, EventArgs e)
        {
            try
            {
                int i = calc.Subraction(int.Parse(txtbox_calc1.Text), int.Parse(txtbox_calc2.Text));
                txtbox_calc_result.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_calc_times_Click(object sender, EventArgs e)
        {
            try
            {
                int i = calc.Multiplication(int.Parse(txtbox_calc1.Text), int.Parse(txtbox_calc2.Text));
                txtbox_calc_result.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_calc_divide_Click(object sender, EventArgs e)
        {
            try
            {
                int i = calc.Division(int.Parse(txtbox_calc1.Text), int.Parse(txtbox_calc2.Text));
                txtbox_calc_result.Text = i.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_tqbf_Click(object sender, EventArgs e)
        {
            try
            {
                txtbox_calc_result.Text = otherDLL.tqbfMultiplier(int.Parse(txtbox_calc_result.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
