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
    public partial class Exercicio25 : Form
    {
        public Exercicio25()
        {
            InitializeComponent();
        }

        public void CriaTabuada(int numero)
        {
            label_resultado.Text = "";

            for (int i = 1; i <= 10; i++)
            {
                label_resultado.Text += $"{numero} x {i} = {numero * i}\n";
            }
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(((Button)sender).Tag);
            CriaTabuada(numero);
        }
    }
}
