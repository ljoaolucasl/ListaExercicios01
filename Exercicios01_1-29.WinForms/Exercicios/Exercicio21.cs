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
    public partial class Exercicio21 : Form
    {
        public Exercicio21()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_a.Text != "" && textBox_b.Text != "")
            {
                double resultado;

                if (double.Parse(textBox_a.Text) == double.Parse(textBox_b.Text))
                {
                    resultado = double.Parse(textBox_a.Text) + double.Parse(textBox_b.Text);
                    label_resultado.Text = "Como A é igual a B, eles foram somados: C = " + resultado;
                }
                else
                {
                    resultado = double.Parse(textBox_a.Text) * double.Parse(textBox_b.Text);
                    label_resultado.Text = "Como A é diferente de B, eles foram multiplicados: C = " + resultado;
                }
            }
        }
    }
}
