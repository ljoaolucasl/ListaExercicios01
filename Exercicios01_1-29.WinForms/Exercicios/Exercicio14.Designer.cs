namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio14
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
            this.label_anos = new System.Windows.Forms.Label();
            this.textBox_anos = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(117, 288);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 3;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_anos
            // 
            this.label_anos.AutoSize = true;
            this.label_anos.Location = new System.Drawing.Point(185, 218);
            this.label_anos.Name = "label_anos";
            this.label_anos.Size = new System.Drawing.Size(63, 13);
            this.label_anos.TabIndex = 13;
            this.label_anos.Text = "Anos/Idade";
            // 
            // textBox_anos
            // 
            this.textBox_anos.Location = new System.Drawing.Point(184, 237);
            this.textBox_anos.MaxLength = 4;
            this.textBox_anos.Name = "textBox_anos";
            this.textBox_anos.Size = new System.Drawing.Size(118, 20);
            this.textBox_anos.TabIndex = 2;
            this.textBox_anos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_anos_KeyPress);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(20, 218);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(35, 13);
            this.label_nome.TabIndex = 11;
            this.label_nome.Text = "Nome";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(19, 237);
            this.textBox_nome.MaxLength = 8;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(118, 20);
            this.textBox_nome.TabIndex = 1;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(24, 23);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(267, 25);
            this.label_titulo.TabIndex = 9;
            this.label_titulo.Text = "Converter Anos em Dias";
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(29, 123);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(262, 58);
            this.label_resultado.TabIndex = 17;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exercicio14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 326);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_anos);
            this.Controls.Add(this.textBox_anos);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio14";
            this.Text = "Exercicio14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_anos;
        private System.Windows.Forms.TextBox textBox_anos;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_resultado;
    }
}