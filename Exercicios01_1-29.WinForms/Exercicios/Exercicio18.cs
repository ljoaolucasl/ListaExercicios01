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
    public partial class Exercicio18 : Form
    {
        public Exercicio18()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_valor1.Text != "" && textBox_valor2.Text != "" && textBox_valor3.Text != "")
            {
                label_resultado.Text = textBox_valor3.Text + " - " + textBox_valor2.Text + " - " + textBox_valor1.Text;
            }
        }

        private void textBox_valor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
