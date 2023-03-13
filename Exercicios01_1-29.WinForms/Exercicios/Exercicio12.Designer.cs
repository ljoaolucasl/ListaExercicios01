namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio12
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.button_calcular = new System.Windows.Forms.Button();
            this.label_comprimento = new System.Windows.Forms.Label();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.label_largura = new System.Windows.Forms.Label();
            this.textBox_largura = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_resultado.Location = new System.Drawing.Point(175, 98);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(180, 24);
            this.label_resultado.TabIndex = 19;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(28, 222);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 3;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_comprimento
            // 
            this.label_comprimento.AutoSize = true;
            this.label_comprimento.Location = new System.Drawing.Point(10, 147);
            this.label_comprimento.Name = "label_comprimento";
            this.label_comprimento.Size = new System.Drawing.Size(68, 13);
            this.label_comprimento.TabIndex = 15;
            this.label_comprimento.Text = "Comprimento";
            // 
            // textBox_altura
            // 
            this.textBox_altura.Location = new System.Drawing.Point(9, 166);
            this.textBox_altura.MaxLength = 7;
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(99, 20);
            this.textBox_altura.TabIndex = 2;
            this.textBox_altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_largura_KeyPress);
            // 
            // label_largura
            // 
            this.label_largura.AutoSize = true;
            this.label_largura.Location = new System.Drawing.Point(10, 84);
            this.label_largura.Name = "label_largura";
            this.label_largura.Size = new System.Drawing.Size(43, 13);
            this.label_largura.TabIndex = 13;
            this.label_largura.Text = "Largura";
            // 
            // textBox_largura
            // 
            this.textBox_largura.Location = new System.Drawing.Point(9, 103);
            this.textBox_largura.MaxLength = 7;
            this.textBox_largura.Name = "textBox_largura";
            this.textBox_largura.Size = new System.Drawing.Size(99, 20);
            this.textBox_largura.TabIndex = 1;
            this.textBox_largura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_largura_KeyPress);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(50, 20);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(277, 25);
            this.label_titulo.TabIndex = 10;
            this.label_titulo.Text = "Calcular Área do Terreno";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Exercicios01_1_29.WinForms.Properties.Resources.retangulo_terreno;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(175, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "metros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "metros";
            // 
            // Exercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 286);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_comprimento);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.label_largura);
            this.Controls.Add(this.textBox_largura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio12";
            this.Text = "Exercicio12";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_comprimento;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.Label label_largura;
        private System.Windows.Forms.TextBox textBox_largura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}