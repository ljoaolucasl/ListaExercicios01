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
    public partial class Exercicio24 : Form
    {
        public Exercicio24()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            int numero;
            int resultado = 0;

            label_resultado.Text = "3";

            for (int i = 2; i < 167; i++)
            {
                numero = 3 * i;

                if (numero % 2 != 0 && numero <= 495)
                {
                    label_resultado.Text += ", " + numero;
                    resultado += numero;
                }

                label_soma.Text = "= " + Convert.ToString(resultado);
            }
        }
    }
}
