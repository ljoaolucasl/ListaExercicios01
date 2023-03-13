namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio17
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
            this.label_c = new System.Windows.Forms.Label();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_resultado.Location = new System.Drawing.Point(22, 152);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(283, 18);
            this.label_resultado.TabIndex = 24;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(120, 341);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(188, 213);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(14, 13);
            this.label_b.TabIndex = 22;
            this.label_b.Text = "B";
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(187, 232);
            this.textBox_b.MaxLength = 10;
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(118, 20);
            this.textBox_b.TabIndex = 2;
            this.textBox_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_a_KeyPress);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(23, 213);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(14, 13);
            this.label_a.TabIndex = 20;
            this.label_a.Text = "A";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(22, 232);
            this.textBox_a.MaxLength = 10;
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(118, 20);
            this.textBox_a.TabIndex = 1;
            this.textBox_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_a_KeyPress);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(57, 33);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(210, 25);
            this.label_titulo.TabIndex = 18;
            this.label_titulo.Text = "A + B menor que C";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(104, 273);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(14, 13);
            this.label_c.TabIndex = 26;
            this.label_c.Text = "C";
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(103, 292);
            this.textBox_c.MaxLength = 10;
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(118, 20);
            this.textBox_c.TabIndex = 3;
            this.textBox_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_a_KeyPress);
            // 
            // Exercicio17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 379);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio17";
            this.Text = "Exercicio17";
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
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.TextBox textBox_c;
    }
}