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
    public partial class Exercicio28 : Form
    {
        public Exercicio28()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            int tresMultiplo;
            int cincoMultiplo;

            int tresX = 1;
            int cincoX = 1;

            label_resultado.Text = "1";

            for (int i = 2; i <= 100; i++)
            {
                tresMultiplo = 3 * tresX;
                cincoMultiplo = 5 * cincoX;

                if (i == tresMultiplo && i != cincoMultiplo)
                {
                    label_resultado.Text += ", Fizz";
                    tresX++;
                }
                else if (i == cincoMultiplo && i != tresMultiplo)
                {
                    label_resultado.Text += ", Buzz";
                    cincoX++;
                }
                else if (i == cincoMultiplo && i == tresMultiplo)
                {
                    label_resultado.Text += ", FizzBuzz";
                    tresX++;
                    cincoX++;
                }
                else
                {
                    label_resultado.Text += ", " + i;
                }
            }
        }
    }
}
