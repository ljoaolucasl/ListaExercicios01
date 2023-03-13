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
    public partial class Exercicio14 : Form
    {
        public Exercicio14()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_nome.Text != "" && textBox_anos.Text != "")
            {
                double resultado = Convert.ToDouble(textBox_anos.Text) * 365;

                label_resultado.Text = textBox_nome.Text + ", você já viveu " + resultado + " dias!";
            }
        }

        private void textBox_anos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
