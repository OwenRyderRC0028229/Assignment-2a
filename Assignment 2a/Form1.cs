using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(Res1.Text);
                double R2 = Convert.ToDouble(Res2.Text);
                double TRA2 = 1 / ((1 / R1) + (1 / R2));

                TR2.Text = "Total Resistance = " + TRA2.ToString("0.00");

            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(Res3.Text);
                double R2 = Convert.ToDouble(Res4.Text);
                double R3 = Convert.ToDouble(Res5.Text);
                double TRA3 = 1 / ((1 / R1) + (1 / R2) + (1 / R3));

                TR3.Text = "Total Resistance = " + TRA3.ToString("0.00");

            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(Res6.Text);
                double R2 = Convert.ToDouble(Res7.Text);
                double R3 = Convert.ToDouble(Res8.Text);
                double R4 = Convert.ToDouble(Res9.Text);
                double TRA4 = 1 / ((1 / R1) + (1 / R2) + (1 / R3) + (1 / R4));

                TR4.Text = "Total Resistance = " + TRA4.ToString("0.00");

            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(Res10.Text);
                double R2 = Convert.ToDouble(Res11.Text);
                double R3 = Convert.ToDouble(Res12.Text);
                double R4 = Convert.ToDouble(Res13.Text);
                double R5 = Convert.ToDouble(Res14.Text);
                double TRA5 = 1 / ((1 / R1) + (1 / R2) + (1 / R3) + (1 / R4) + (1 / R5));

                TR5.Text = "Total Resistance = " + TRA5.ToString("0.00");
                TR5.Text = "Total Resistance = " + TRA5.ToString("0.00");

            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(Res1S.Text);
                double R2 = Convert.ToDouble(Res2S.Text);
                double TRA2S = R1 + R2;

                TR2S.Text = "Total Resistance = " + TRA2S.ToString("0.00");

            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(Res3S.Text);
                double R2 = Convert.ToDouble(Res4S.Text);
                double R3 = Convert.ToDouble(Res5S.Text);
                double TRA3S = R1 + R2 + R3;

                TR3S.Text = "Total Resistance = " + TRA3S.ToString("0.00");

            }
            catch
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(Res6S.Text);
                double R2 = Convert.ToDouble(Res7S.Text);
                double R3 = Convert.ToDouble(Res8S.Text);
                double R4 = Convert.ToDouble(Res9S.Text);
                double TRA4S = R1 + R2 + R3 + R4;

                TR4S.Text = "Total Resistance = " + TRA4S.ToString("0.00");

            }
            catch
            {

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double R1 = Convert.ToDouble(Res10S.Text);
                double R2 = Convert.ToDouble(Res11S.Text);
                double R3 = Convert.ToDouble(Res12S.Text);
                double R4 = Convert.ToDouble(Res13S.Text);
                double R5 = Convert.ToDouble(Res14S.Text);
                double TRA5S = R1 + R2 + R3 + R4 + R5;

                TR5S.Text = "Total Resistance = " + TRA5S.ToString("0.00");
                
            }
            catch
            {

            }
        }
    }
    }
    
    
    
    


            
            
