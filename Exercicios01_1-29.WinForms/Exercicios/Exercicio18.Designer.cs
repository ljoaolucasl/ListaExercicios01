namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio18
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
            this.textBox_valor1 = new System.Windows.Forms.TextBox();
            this.label__valor1 = new System.Windows.Forms.Label();
            this.label__valor2 = new System.Windows.Forms.Label();
            this.textBox_valor2 = new System.Windows.Forms.TextBox();
            this.label__valor3 = new System.Windows.Forms.Label();
            this.textBox_valor3 = new System.Windows.Forms.TextBox();
            this.button_calcular = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_valor1
            // 
            this.textBox_valor1.Location = new System.Drawing.Point(12, 228);
            this.textBox_valor1.MaxLength = 7;
            this.textBox_valor1.Name = "textBox_valor1";
            this.textBox_valor1.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor1.TabIndex = 1;
            this.textBox_valor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_valor1_KeyPress);
            // 
            // label__valor1
            // 
            this.label__valor1.AutoSize = true;
            this.label__valor1.Location = new System.Drawing.Point(9, 212);
            this.label__valor1.Name = "label__valor1";
            this.label__valor1.Size = new System.Drawing.Size(40, 13);
            this.label__valor1.TabIndex = 1;
            this.label__valor1.Text = "Valor 1";
            // 
            // label__valor2
            // 
            this.label__valor2.AutoSize = true;
            this.label__valor2.Location = new System.Drawing.Point(127, 212);
            this.label__valor2.Name = "label__valor2";
            this.label__valor2.Size = new System.Drawing.Size(40, 13);
            this.label__valor2.TabIndex = 3;
            this.label__valor2.Text = "Valor 2";
            // 
            // textBox_valor2
            // 
            this.textBox_valor2.Location = new System.Drawing.Point(130, 228);
            this.textBox_valor2.MaxLength = 7;
            this.textBox_valor2.Name = "textBox_valor2";
            this.textBox_valor2.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor2.TabIndex = 2;
            this.textBox_valor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_valor1_KeyPress);
            // 
            // label__valor3
            // 
            this.label__valor3.AutoSize = true;
            this.label__valor3.Location = new System.Drawing.Point(246, 212);
            this.label__valor3.Name = "label__valor3";
            this.label__valor3.Size = new System.Drawing.Size(40, 13);
            this.label__valor3.TabIndex = 5;
            this.label__valor3.Text = "Valor 3";
            // 
            // textBox_valor3
            // 
            this.textBox_valor3.Location = new System.Drawing.Point(249, 228);
            this.textBox_valor3.MaxLength = 7;
            this.textBox_valor3.Name = "textBox_valor3";
            this.textBox_valor3.Size = new System.Drawing.Size(100, 20);
            this.textBox_valor3.TabIndex = 3;
            this.textBox_valor3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_valor1_KeyPress);
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(139, 271);
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
            this.label_resultado.Location = new System.Drawing.Point(12, 114);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(336, 68);
            this.label_resultado.TabIndex = 19;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(64, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(232, 25);
            this.label_titulo.TabIndex = 20;
            this.label_titulo.Text = "Ordem Descrescente";
            // 
            // Exercicio18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 309);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label__valor3);
            this.Controls.Add(this.textBox_valor3);
            this.Controls.Add(this.label__valor2);
            this.Controls.Add(this.textBox_valor2);
            this.Controls.Add(this.label__valor1);
            this.Controls.Add(this.textBox_valor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio18";
            this.Text = "Exercicio18";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_valor1;
        private System.Windows.Forms.Label label__valor1;
        private System.Windows.Forms.Label label__valor2;
        private System.Windows.Forms.TextBox textBox_valor2;
        private System.Windows.Forms.Label label__valor3;
        private System.Windows.Forms.TextBox textBox_valor3;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Label label_titulo;
    }
}