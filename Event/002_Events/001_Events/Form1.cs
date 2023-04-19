using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001_Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // EventArgs e - містить допоміжні дані про подію,
        // у разі, чи була натиснута кнопка мишею (MouseEventArgs) чи клавіатурою (EventArgs).
        // object sender – джерело події

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Натиснута кнопка: " + sender.ToString(), "Чим натиснули: " + e.ToString());
        }
    }
}
