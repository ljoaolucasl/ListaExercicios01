namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio02
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
            this.button_calcular1 = new System.Windows.Forms.Button();
            this.label_celsius = new System.Windows.Forms.Label();
            this.textBox_celsius = new System.Windows.Forms.TextBox();
            this.label_fahrenheit = new System.Windows.Forms.Label();
            this.textBox_fahrenheit = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.button_calcular2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_calcular1
            // 
            this.button_calcular1.Location = new System.Drawing.Point(40, 160);
            this.button_calcular1.Name = "button_calcular1";
            this.button_calcular1.Size = new System.Drawing.Size(80, 26);
            this.button_calcular1.TabIndex = 2;
            this.button_calcular1.Text = "Fahrenheit ->";
            this.button_calcular1.UseVisualStyleBackColor = true;
            this.button_calcular1.Click += new System.EventHandler(this.button_calcular1_Click);
            // 
            // label_celsius
            // 
            this.label_celsius.AutoSize = true;
            this.label_celsius.Location = new System.Drawing.Point(240, 73);
            this.label_celsius.Name = "label_celsius";
            this.label_celsius.Size = new System.Drawing.Size(40, 13);
            this.label_celsius.TabIndex = 13;
            this.label_celsius.Text = "Celsius";
            // 
            // textBox_celsius
            // 
            this.textBox_celsius.Location = new System.Drawing.Point(239, 92);
            this.textBox_celsius.MaxLength = 7;
            this.textBox_celsius.Name = "textBox_celsius";
            this.textBox_celsius.Size = new System.Drawing.Size(118, 20);
            this.textBox_celsius.TabIndex = 3;
            this.textBox_celsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fahrenheit_KeyPress);
            // 
            // label_fahrenheit
            // 
            this.label_fahrenheit.AutoSize = true;
            this.label_fahrenheit.Location = new System.Drawing.Point(24, 73);
            this.label_fahrenheit.Name = "label_fahrenheit";
            this.label_fahrenheit.Size = new System.Drawing.Size(57, 13);
            this.label_fahrenheit.TabIndex = 11;
            this.label_fahrenheit.Text = "Fahrenheit";
            // 
            // textBox_fahrenheit
            // 
            this.textBox_fahrenheit.Location = new System.Drawing.Point(23, 92);
            this.textBox_fahrenheit.MaxLength = 7;
            this.textBox_fahrenheit.Name = "textBox_fahrenheit";
            this.textBox_fahrenheit.Size = new System.Drawing.Size(118, 20);
            this.textBox_fahrenheit.TabIndex = 1;
            this.textBox_fahrenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fahrenheit_KeyPress);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(22, 18);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(340, 25);
            this.label_titulo.TabIndex = 9;
            this.label_titulo.Text = "Converter Fahrenheit e Celsius";
            // 
            // button_calcular2
            // 
            this.button_calcular2.Location = new System.Drawing.Point(257, 160);
            this.button_calcular2.Name = "button_calcular2";
            this.button_calcular2.Size = new System.Drawing.Size(80, 26);
            this.button_calcular2.TabIndex = 4;
            this.button_calcular2.Text = "<- Celsius";
            this.button_calcular2.UseVisualStyleBackColor = true;
            this.button_calcular2.Click += new System.EventHandler(this.button_calcular2_Click);
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 221);
            this.Controls.Add(this.button_calcular2);
            this.Controls.Add(this.button_calcular1);
            this.Controls.Add(this.label_celsius);
            this.Controls.Add(this.textBox_celsius);
            this.Controls.Add(this.label_fahrenheit);
            this.Controls.Add(this.textBox_fahrenheit);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular1;
        private System.Windows.Forms.Label label_celsius;
        private System.Windows.Forms.TextBox textBox_celsius;
        private System.Windows.Forms.Label label_fahrenheit;
        private System.Windows.Forms.TextBox textBox_fahrenheit;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Button button_calcular2;
    }
}