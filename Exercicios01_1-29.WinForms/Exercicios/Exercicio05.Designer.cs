namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio05
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
            this.textBox_raio = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_raio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(46, 191);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 2;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // textBox_raio
            // 
            this.textBox_raio.Location = new System.Drawing.Point(26, 138);
            this.textBox_raio.MaxLength = 7;
            this.textBox_raio.Name = "textBox_raio";
            this.textBox_raio.Size = new System.Drawing.Size(118, 20);
            this.textBox_raio.TabIndex = 1;
            this.textBox_raio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_raio_KeyPress);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(33, 21);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(292, 25);
            this.label_titulo.TabIndex = 9;
            this.label_titulo.Text = "Calcular Volume da Esfera";
            // 
            // label_raio
            // 
            this.label_raio.AutoSize = true;
            this.label_raio.Location = new System.Drawing.Point(27, 122);
            this.label_raio.Name = "label_raio";
            this.label_raio.Size = new System.Drawing.Size(32, 13);
            this.label_raio.TabIndex = 15;
            this.label_raio.Text = "Raio³";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercicios01_1_29.WinForms.Properties.Resources.esfera;
            this.pictureBox1.Location = new System.Drawing.Point(180, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_resultado.Location = new System.Drawing.Point(180, 58);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(136, 62);
            this.label_resultado.TabIndex = 18;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 283);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_raio);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.textBox_raio);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio05";
            this.Text = "Exercicio05";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.TextBox textBox_raio;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_raio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_resultado;
    }
}