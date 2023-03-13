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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_kmInicial.Text != "" && textBox_kmFinal.Text != "" && textBox_consumo.Text != "")
            {
                double resultado = (Convert.ToDouble(textBox_kmFinal.Text) - Convert.ToDouble(textBox_kmInicial.Text)) / Convert.ToDouble(textBox_consumo.Text);
                label_resultado.Text = Math.Round(resultado, 1) + "km/l";
            }
        }

        private void textBox_kmInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
