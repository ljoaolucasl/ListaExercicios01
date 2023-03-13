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
    public partial class Exercicio09 : Form
    {
        public Exercicio09()
        {
            InitializeComponent();
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            if (textBox_nome.Text != "" && textBox_nota1.Text != "" && textBox_nota2.Text != "" && textBox_nota3.Text != "")
            {
                string[] geral = new string[5];

                double resultado = 3 / (1 / Convert.ToDouble(textBox_nota1.Text) + 1 / Convert.ToDouble(textBox_nota2.Text) + 1 / Convert.ToDouble(textBox_nota3.Text));

                geral[0] = textBox_nome.Text;
                geral[1] = textBox_nota1.Text;
                geral[2] = textBox_nota2.Text;
                geral[3] = textBox_nota3.Text;
                geral[4] = Convert.ToString(Math.Round(resultado, 2));

                ListViewItem itens;
                itens = new ListViewItem(geral);
                listView_geral.Items.Add(itens);

                textBox_nome.Text = "";
                textBox_nota1.Text = "";
                textBox_nota2.Text = "";
                textBox_nota3.Text = "";
            }
        }

        private void textBox_nota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
