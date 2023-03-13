namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio27
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
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label_resultado = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(98, 501);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(75, 23);
            this.button_calcular.TabIndex = 46;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(94, 470);
            this.textBox_numero.MaxLength = 8;
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(81, 20);
            this.textBox_numero.TabIndex = 1;
            this.textBox_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numero_KeyPress);
            // 
            // label_resultado
            // 
            this.label_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_resultado.Location = new System.Drawing.Point(12, 43);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(249, 405);
            this.label_resultado.TabIndex = 48;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(12, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(208, 25);
            this.label_titulo.TabIndex = 47;
            this.label_titulo.Text = "Calcular Fibonacci";
            // 
            // Exercicio27
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 533);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio27";
            this.Text = "Exercicio27";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Label label_titulo;
    }
}