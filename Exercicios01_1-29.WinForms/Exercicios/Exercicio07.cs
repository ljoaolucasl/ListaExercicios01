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
    public partial class Exercicio07 : Form
    {
        public Exercicio07()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_salarioBase.Text != "" && textBox_vendas.Text != "" && textBox_comissao.Text != "")
            {
                double resultado = Convert.ToDouble(textBox_vendas.Text) * (Convert.ToDouble(textBox_comissao.Text)/100) + Convert.ToDouble(textBox_salarioBase.Text);
                label_resultado.Text = "R$" + Math.Round(resultado, 2);
            }
        }

        private void textBox_salarioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
