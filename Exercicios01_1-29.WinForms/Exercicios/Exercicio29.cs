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
    public partial class Exercicio29 : Form
    {
        public Exercicio29()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            tableLayoutPanel_tabuada.Controls.Clear();

            for (int i = 0; i < 10; i++)
            {
                Label label1 = CriaTabuada(i + 1);
                tableLayoutPanel_tabuada.Controls.Add(label1, i, 0);
            }
        }

        public Label CriaTabuada(int numero)
        {
            Label label1 = new Label();
            label1.AutoSize = true;
            for (int i = 1; i <= 10; i++)
            {
                label1.Text += $"{numero} x {i} = {numero * i}\n";
            }
            return label1;
        }
    }
}
