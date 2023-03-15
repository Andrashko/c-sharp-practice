using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);

            {
                if (radioButton1.Checked)
                {
                    textBox3.Text = (a % b).ToString(); 
                }

                else if (radioButton2.Checked)
                {
                     textBox3.Text = Math.Pow(a, b).ToString(); 
                }

                else if (radioButton3.Checked)
                {
                    textBox3.Text = a + b.ToString();
                }

                else if (radioButton4.Checked)
                {
                    textBox3.Text = (a / b).ToString();
                }

                else

                {
                    MessageBox.Show ("Введіть числа");
                    return;
                }
               
            }

        }

    }
}
