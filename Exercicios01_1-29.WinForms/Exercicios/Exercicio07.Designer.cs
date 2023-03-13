namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio07
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_calcular = new System.Windows.Forms.Button();
            this.label_comissao = new System.Windows.Forms.Label();
            this.textBox_comissao = new System.Windows.Forms.TextBox();
            this.label_vendas = new System.Windows.Forms.Label();
            this.textBox_vendas = new System.Windows.Forms.TextBox();
            this.label_salarioBase = new System.Windows.Forms.Label();
            this.textBox_salarioBase = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(30, 267);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_comissao
            // 
            this.label_comissao.AutoSize = true;
            this.label_comissao.Location = new System.Drawing.Point(17, 205);
            this.label_comissao.Name = "label_comissao";
            this.label_comissao.Size = new System.Drawing.Size(69, 13);
            this.label_comissao.TabIndex = 15;
            this.label_comissao.Text = "Comissão (%)";
            // 
            // textBox_comissao
            // 
            this.textBox_comissao.Location = new System.Drawing.Point(16, 224);
            this.textBox_comissao.MaxLength = 7;
            this.textBox_comissao.Name = "textBox_comissao";
            this.textBox_comissao.Size = new System.Drawing.Size(118, 20);
            this.textBox_comissao.TabIndex = 3;
            this.textBox_comissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_salarioBase_KeyPress);
            // 
            // label_vendas
            // 
            this.label_vendas.AutoSize = true;
            this.label_vendas.Location = new System.Drawing.Point(17, 141);
            this.label_vendas.Name = "label_vendas";
            this.label_vendas.Size = new System.Drawing.Size(85, 13);
            this.label_vendas.TabIndex = 13;
            this.label_vendas.Text = "Total de Vendas";
            // 
            // textBox_vendas
            // 
            this.textBox_vendas.Location = new System.Drawing.Point(16, 160);
            this.textBox_vendas.MaxLength = 7;
            this.textBox_vendas.Name = "textBox_vendas";
            this.textBox_vendas.Size = new System.Drawing.Size(118, 20);
            this.textBox_vendas.TabIndex = 2;
            this.textBox_vendas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_salarioBase_KeyPress);
            // 
            // label_salarioBase
            // 
            this.label_salarioBase.AutoSize = true;
            this.label_salarioBase.Location = new System.Drawing.Point(17, 78);
            this.label_salarioBase.Name = "label_salarioBase";
            this.label_salarioBase.Size = new System.Drawing.Size(66, 13);
            this.label_salarioBase.TabIndex = 11;
            this.label_salarioBase.Text = "Salário Base";
            // 
            // textBox_salarioBase
            // 
            this.textBox_salarioBase.Location = new System.Drawing.Point(16, 97);
            this.textBox_salarioBase.MaxLength = 7;
            this.textBox_salarioBase.Name = "textBox_salarioBase";
            this.textBox_salarioBase.Size = new System.Drawing.Size(118, 20);
            this.textBox_salarioBase.TabIndex = 1;
            this.textBox_salarioBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_salarioBase_KeyPress);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(72, 20);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(240, 25);
            this.label_titulo.TabIndex = 9;
            this.label_titulo.Text = "Calcular Salário Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercicios01_1_29.WinForms.Properties.Resources.comissao3;
            this.pictureBox1.Location = new System.Drawing.Point(189, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_resultado.Location = new System.Drawing.Point(189, 52);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(176, 81);
            this.label_resultado.TabIndex = 18;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exercicio07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 311);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_comissao);
            this.Controls.Add(this.textBox_comissao);
            this.Controls.Add(this.label_vendas);
            this.Controls.Add(this.textBox_vendas);
            this.Controls.Add(this.label_salarioBase);
            this.Controls.Add(this.textBox_salarioBase);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio07";
            this.Text = "Exercicio07";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_comissao;
        private System.Windows.Forms.TextBox textBox_comissao;
        private System.Windows.Forms.Label label_vendas;
        private System.Windows.Forms.TextBox textBox_vendas;
        private System.Windows.Forms.Label label_salarioBase;
        private System.Windows.Forms.TextBox textBox_salarioBase;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_resultado;
    }
}