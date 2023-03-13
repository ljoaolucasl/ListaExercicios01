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
    public partial class Exercicio26 : Form
    {
        public Exercicio26()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_numero.Text != "" && textBox_numero.Text != "0" && textBox_numero.Text != "1")
            {
                label_resultado.Text = "";

                int numero = int.Parse(textBox_numero.Text);
                int resultado = 1;
                label_resultado.Text += $"{numero}! = ";

                for (int i = numero; i > 1; i--)
                {
                    label_resultado.Text += $"{i} x ";
                    resultado *= i;
                }
                label_resultado.Text += $"1 = {resultado}";
                textBox_numero.Text = "";
                textBox_numero.Focus();
            }
        }

        private void textBox_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
