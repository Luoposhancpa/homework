using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsComputed
{
    public partial class Computed : Form
    {
        public Computed()
        {
            InitializeComponent();
        }
        public void compute()
        {
            if (num1.Text.Equals("") || num2.Text.Equals("") || oper.Text.Equals(""))
                res.Text = "";
            else
            {
                try
                {
                    Double num11 = Double.Parse(num1.Text);
                    Double num22 = Double.Parse(num2.Text);
                    switch (oper.Text)
                    {
                        case "+":

                            res.Text = (num11 + num22).ToString();
                            break;
                        case "-":
                            res.Text = (num11 - num22).ToString();
                            break;
                        case "*":
                            res.Text = (num11 * num22).ToString();
                            break;
                        case "/":
                            
                              res.Text = (num11 / num22).ToString();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    res.Text = "出错";
                }
               
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            oper.Text = "+";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oper.Text = "-";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oper.Text = "*";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oper.Text = "/";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compute();
        }
    }
}
