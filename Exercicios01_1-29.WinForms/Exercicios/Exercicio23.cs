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
    public partial class Exercicio23 : Form
    {
        public Exercicio23()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            label_resultado.Text = "101";

            for (int i = 103; i < 200; i++)
            {
                if (i % 2 != 0)
                {
                    label_resultado.Text += ", " + i;
                }
            }
        }
    }
}
