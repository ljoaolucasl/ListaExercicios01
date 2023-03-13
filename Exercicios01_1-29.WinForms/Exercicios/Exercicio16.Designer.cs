namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio16
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
            this.label_salarioInicial = new System.Windows.Forms.Label();
            this.textBox_salarioInicial = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_aumento = new System.Windows.Forms.Label();
            this.label_salarioFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(127, 302);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 2;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_salarioInicial
            // 
            this.label_salarioInicial.AutoSize = true;
            this.label_salarioInicial.Location = new System.Drawing.Point(26, 93);
            this.label_salarioInicial.Name = "label_salarioInicial";
            this.label_salarioInicial.Size = new System.Drawing.Size(69, 13);
            this.label_salarioInicial.TabIndex = 21;
            this.label_salarioInicial.Text = "Salário Inicial";
            // 
            // textBox_salarioInicial
            // 
            this.textBox_salarioInicial.Location = new System.Drawing.Point(25, 112);
            this.textBox_salarioInicial.MaxLength = 7;
            this.textBox_salarioInicial.Name = "textBox_salarioInicial";
            this.textBox_salarioInicial.Size = new System.Drawing.Size(118, 20);
            this.textBox_salarioInicial.TabIndex = 1;
            this.textBox_salarioInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_salarioInicial_KeyPress);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(82, 21);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(172, 25);
            this.label_titulo.TabIndex = 19;
            this.label_titulo.Text = "Calculo Salário";
            // 
            // label_aumento
            // 
            this.label_aumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aumento.Location = new System.Drawing.Point(26, 162);
            this.label_aumento.Name = "label_aumento";
            this.label_aumento.Size = new System.Drawing.Size(293, 16);
            this.label_aumento.TabIndex = 28;
            this.label_aumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_salarioFinal
            // 
            this.label_salarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salarioFinal.Location = new System.Drawing.Point(26, 212);
            this.label_salarioFinal.Name = "label_salarioFinal";
            this.label_salarioFinal.Size = new System.Drawing.Size(293, 16);
            this.label_salarioFinal.TabIndex = 29;
            this.label_salarioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Exercicio16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 340);
            this.Controls.Add(this.label_salarioFinal);
            this.Controls.Add(this.label_aumento);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_salarioInicial);
            this.Controls.Add(this.textBox_salarioInicial);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio16";
            this.Text = "Exercicio16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_salarioInicial;
        private System.Windows.Forms.TextBox textBox_salarioInicial;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_aumento;
        private System.Windows.Forms.Label label_salarioFinal;
    }
}