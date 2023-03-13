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
    public partial class Exercicio12 : Form
    {
        public Exercicio12()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_altura.Text != "" && textBox_largura.Text != "")
            {
                double resultado = Convert.ToDouble(textBox_altura.Text) * Convert.ToDouble(textBox_largura.Text);

                label_resultado.Text = resultado + "m²";
            }
        }

        private void textBox_largura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
