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
    public partial class Exercicio20 : Form
    {
        public Exercicio20()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if(textBox_numero.Text != "")
            {
                if (int.Parse(textBox_numero.Text) % 2 == 0)
                {
                    label_resultado.Text = textBox_numero.Text + " é Par!";
                    textBox_numero.Text = "";
                    textBox_numero.Focus();
                }
                else
                {
                    label_resultado.Text = textBox_numero.Text + " é Ímpar!";
                    textBox_numero.Text = "";
                    textBox_numero.Focus();
                }
            }
        }
    }
}
