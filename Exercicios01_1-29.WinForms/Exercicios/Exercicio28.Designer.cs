namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio28
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
            this.label_resultado = new System.Windows.Forms.Label();
            this.label_titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(249, 292);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 37;
            this.button_calcular.Text = "Gerar";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_resultado.Location = new System.Drawing.Point(38, 81);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(505, 169);
            this.label_resultado.TabIndex = 39;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(32, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(511, 50);
            this.label_titulo.TabIndex = 40;
            this.label_titulo.Text = "1 a 100\r\nmúltiplos de três(Fizz) múltiplos de cinco(Buzz)";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exercicio28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 350);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio28";
            this.Text = "Exercicio28";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Label label_titulo;
    }
}