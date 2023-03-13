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
    public partial class Exercicio27 : Form
    {
        public Exercicio27()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_numero.Text != "" && textBox_numero.Text != "0")
            {
                int a = 0;
                int b = 1;

                int c = 0;

                int numero = int.Parse(textBox_numero.Text);

                label_resultado.Text = "0, 1";

                while (c < numero)
                {
                    c = a + b;

                    if (c <= numero)
                    {
                        label_resultado.Text += $", {c}";
                    }

                    a = b;
                    b = c;
                }
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
