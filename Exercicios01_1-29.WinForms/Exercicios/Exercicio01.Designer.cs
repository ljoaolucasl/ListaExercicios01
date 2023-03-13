namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio01
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.textBox_largura = new System.Windows.Forms.TextBox();
            this.label_largura = new System.Windows.Forms.Label();
            this.label_altura = new System.Windows.Forms.Label();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.label_profundidade = new System.Windows.Forms.Label();
            this.textBox_profundidade = new System.Windows.Forms.TextBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(30, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(331, 25);
            this.label_titulo.TabIndex = 0;
            this.label_titulo.Text = "Calcular Volume do Retângulo";
            // 
            // textBox_largura
            // 
            this.textBox_largura.Location = new System.Drawing.Point(12, 87);
            this.textBox_largura.MaxLength = 7;
            this.textBox_largura.Name = "textBox_largura";
            this.textBox_largura.Size = new System.Drawing.Size(118, 20);
            this.textBox_largura.TabIndex = 1;
            this.textBox_largura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_largura_KeyPress);
            // 
            // label_largura
            // 
            this.label_largura.AutoSize = true;
            this.label_largura.Location = new System.Drawing.Point(13, 68);
            this.label_largura.Name = "label_largura";
            this.label_largura.Size = new System.Drawing.Size(43, 13);
            this.label_largura.TabIndex = 3;
            this.label_largura.Text = "Largura";
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Location = new System.Drawing.Point(13, 131);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(34, 13);
            this.label_altura.TabIndex = 5;
            this.label_altura.Text = "Altura";
            // 
            // textBox_altura
            // 
            this.textBox_altura.Location = new System.Drawing.Point(12, 150);
            this.textBox_altura.MaxLength = 7;
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(118, 20);
            this.textBox_altura.TabIndex = 2;
            this.textBox_altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_largura_KeyPress);
            // 
            // label_profundidade
            // 
            this.label_profundidade.AutoSize = true;
            this.label_profundidade.Location = new System.Drawing.Point(13, 195);
            this.label_profundidade.Name = "label_profundidade";
            this.label_profundidade.Size = new System.Drawing.Size(70, 13);
            this.label_profundidade.TabIndex = 7;
            this.label_profundidade.Text = "Profundidade";
            // 
            // textBox_profundidade
            // 
            this.textBox_profundidade.Location = new System.Drawing.Point(12, 214);
            this.textBox_profundidade.MaxLength = 7;
            this.textBox_profundidade.Name = "textBox_profundidade";
            this.textBox_profundidade.Size = new System.Drawing.Size(118, 20);
            this.textBox_profundidade.TabIndex = 3;
            this.textBox_profundidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_largura_KeyPress);
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(26, 257);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_resultado.Location = new System.Drawing.Point(182, 57);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(179, 24);
            this.label_resultado.TabIndex = 9;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Exercicios01_1_29.WinForms.Properties.Resources.retangulo;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(182, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Exercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 298);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_profundidade);
            this.Controls.Add(this.textBox_profundidade);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.label_largura);
            this.Controls.Add(this.textBox_largura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio01";
            this.Text = "Exercicio01";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_largura;
        private System.Windows.Forms.Label label_largura;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.Label label_profundidade;
        private System.Windows.Forms.TextBox textBox_profundidade;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_resultado;
    }
}