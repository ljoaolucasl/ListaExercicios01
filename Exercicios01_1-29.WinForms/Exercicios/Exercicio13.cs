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
    public partial class Exercicio13 : Form
    {
        public Exercicio13()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_pao.Text != "" && textBox_broa.Text != "")
            {
                double total = Convert.ToDouble(textBox_pao.Text) * 0.12 + Convert.ToDouble(textBox_broa.Text) * 1.5;
                double guarda = total * 0.10;

                label_paoTotal.Text = "R$" + Math.Round(Convert.ToDouble(textBox_pao.Text) * 0.12, 2);
                label_broaTotal.Text = "R$" + Math.Round(Convert.ToDouble(textBox_broa.Text) * 1.5, 2);

                label_total.Text = "Total: R$" + Math.Round(total, 2);
                label_guarda.Text = "Guardar: R$" + Math.Round(guarda, 2);
            }
        }

        private void textBox_pao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
