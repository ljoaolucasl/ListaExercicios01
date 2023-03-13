using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicios01_1_29.WinForms
{
    public partial class Exercicio19 : Form
    {
        public Exercicio19()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_nome.Text != "" && textBox_peso.Text != "" && textBox_altura.Text != "" && textBox_altura.Text.Length >= 3)
            {
                double imc = 0;

                imc = double.Parse(textBox_peso.Text) / (Math.Pow(double.Parse(textBox_altura.Text) / 100, 2));

                if (imc < 18.5)
                {
                    label_resultado.Text = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc <= 25)
                {
                    label_resultado.Text = "Peso Normal";
                }
                else if (imc >= 25 && imc <= 30)
                {
                    label_resultado.Text = "Acima do peso";
                }
                else if (imc > 30)
                {
                    label_resultado.Text = "Muito acima do peso(obeso)";
                }

                label_imc.Text = Math.Round(imc, 2) + " imc";
            }
            else
            {
                label_resultado.Text = "";
                label_imc.Text = "";
            }
        }

        private void textBox_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
