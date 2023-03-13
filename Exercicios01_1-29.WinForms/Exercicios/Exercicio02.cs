using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios01_1_29.WinForms
{
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void button_calcular1_Click(object sender, EventArgs e)
        {
            if (textBox_fahrenheit.Text != "")
            {
                double temperatura = Convert.ToDouble(textBox_fahrenheit.Text);
                temperatura -= 32;
                temperatura /= 1.8;
                textBox_celsius.Text = Convert.ToString(Math.Round(temperatura, 1));
            }
        }

        private void button_calcular2_Click(object sender, EventArgs e)
        {
            if (textBox_celsius.Text != "")
            {
                double temperatura = Convert.ToDouble(textBox_celsius.Text);
                temperatura *= 1.8;
                temperatura += 32;
                textBox_fahrenheit.Text = Convert.ToString(Math.Round(temperatura, 1));
            }
        }

        private void textBox_fahrenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
