namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio21
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
            this.label_b = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_resultado.Location = new System.Drawing.Point(40, 112);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(286, 99);
            this.label_resultado.TabIndex = 34;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(143, 331);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 3;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(209, 255);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(14, 13);
            this.label_b.TabIndex = 33;
            this.label_b.Text = "B";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(208, 274);
            this.textBox_b.MaxLength = 10;
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(118, 20);
            this.textBox_b.TabIndex = 2;
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(44, 255);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(14, 13);
            this.label_a.TabIndex = 32;
            this.label_a.Text = "A";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(43, 274);
            this.textBox_a.MaxLength = 10;
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(118, 20);
            this.textBox_a.TabIndex = 1;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(57, 18);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(241, 25);
            this.label_titulo.TabIndex = 31;
            this.label_titulo.Text = "Somar ou Multiplicar?";
            // 
            // Exercicio21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 369);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio21";
            this.Text = "Exercicio21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label_titulo;
    }
}