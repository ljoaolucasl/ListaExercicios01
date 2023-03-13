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
    public partial class Exercicio17 : Form
    {
        public Exercicio17()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_a.Text != "" && textBox_b.Text != "" && textBox_c.Text != "")
            {
                double resultado = Convert.ToDouble(textBox_a.Text) + Convert.ToDouble(textBox_b.Text);

                if (resultado < Convert.ToDouble(textBox_c.Text))
                {
                    label_resultado.Text = "A soma de A + B é menor do que C";
                }
                else if (resultado > Convert.ToDouble(textBox_c.Text))
                {
                    label_resultado.Text = "A soma de A + B é maior do que C";
                }
                else if (resultado == Convert.ToDouble(textBox_c.Text)) 
                {
                    label_resultado.Text = "A soma de A + B é igual a C";
                }

            }
        }

        private void textBox_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
