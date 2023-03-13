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
    public partial class Exercicio16 : Form
    {
        public Exercicio16()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_salarioInicial.Text != "")
            {
                double aumento = Convert.ToDouble(textBox_salarioInicial.Text) * 0.15;
                double imposto = (Convert.ToDouble(textBox_salarioInicial.Text) + aumento) * 0.08;

                label_aumento.Text = "Total com Aumento: R$" + Math.Round(aumento + Convert.ToDouble(textBox_salarioInicial.Text), 2);
                label_salarioFinal.Text = "Total com Aumento + Imposto: R$" + Math.Round(aumento + Convert.ToDouble(textBox_salarioInicial.Text) - imposto, 2);
            }
        }

        private void textBox_salarioInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
