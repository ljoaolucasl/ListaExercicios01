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
    public partial class Exercicio05 : Form
    {
        public Exercicio05()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_raio.Text != "")
            {
                double resultado = 1.333333333333333 * Math.PI * Math.Pow(Convert.ToDouble(textBox_raio.Text), 3);
                label_resultado.Text = Math.Round(resultado, 2) + "cm³";
            }
        }

        private void textBox_raio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
