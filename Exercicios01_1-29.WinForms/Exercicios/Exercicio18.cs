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
                //label_resultado.Text = textBox_valor3.Text + " - " + textBox_valor2.Text + " - " + textBox_valor1.Text;
                int a = int.Parse(textBox_valor1.Text);
                int b = int.Parse(textBox_valor2.Text);
                int c = int.Parse(textBox_valor3.Text);

                int maior = Math.Max(a, Math.Max(b, c));
                int menor = Math.Min(a, Math.Min(b, c));
                int meio = (a + b + c) - (maior + menor);

                label_resultado.Text = $"{maior} - {meio} - {menor}";
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
