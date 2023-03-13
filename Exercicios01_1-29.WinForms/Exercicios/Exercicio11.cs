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
    public partial class Exercicio11 : Form
    {
        public Exercicio11()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(textBox_numero.Text);

            int contador = 0;

            for (int i = 1; i <= numero; i++)
            {
                double primo = numero % i;

                if (primo == 0)
                {
                    contador++;
                }
            }

            if (contador <= 2 && numero != 0)
            {
                label_resultado.ForeColor = Color.Green;
                label_resultado.Text = numero + " é primo";
                textBox_numero.Text = "";
                textBox_numero.Focus();
            }
            else if (contador > 2 || numero == 0)
            {
                label_resultado.ForeColor = Color.Maroon;
                label_resultado.Text = numero + " não é primo";
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
