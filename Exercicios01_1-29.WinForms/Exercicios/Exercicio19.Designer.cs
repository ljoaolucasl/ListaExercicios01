namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio19
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
            this.label_peso = new System.Windows.Forms.Label();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.label_imc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.Location = new System.Drawing.Point(156, 100);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(187, 55);
            this.label_resultado.TabIndex = 24;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(27, 284);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_peso
            // 
            this.label_peso.AutoSize = true;
            this.label_peso.Location = new System.Drawing.Point(13, 142);
            this.label_peso.Name = "label_peso";
            this.label_peso.Size = new System.Drawing.Size(31, 13);
            this.label_peso.TabIndex = 22;
            this.label_peso.Text = "Peso";
            // 
            // textBox_peso
            // 
            this.textBox_peso.Location = new System.Drawing.Point(12, 161);
            this.textBox_peso.MaxLength = 4;
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(118, 20);
            this.textBox_peso.TabIndex = 2;
            this.textBox_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_peso_KeyPress);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(13, 81);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(35, 13);
            this.label_nome.TabIndex = 20;
            this.label_nome.Text = "Nome";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(12, 100);
            this.textBox_nome.MaxLength = 8;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(118, 20);
            this.textBox_nome.TabIndex = 1;
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(12, 24);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(147, 25);
            this.label_titulo.TabIndex = 18;
            this.label_titulo.Text = "Calcular IMC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Altura";
            // 
            // textBox_altura
            // 
            this.textBox_altura.Location = new System.Drawing.Point(12, 224);
            this.textBox_altura.MaxLength = 4;
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(118, 20);
            this.textBox_altura.TabIndex = 3;
            this.textBox_altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_peso_KeyPress);
            // 
            // label_imc
            // 
            this.label_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_imc.Location = new System.Drawing.Point(156, 163);
            this.label_imc.Name = "label_imc";
            this.label_imc.Size = new System.Drawing.Size(187, 18);
            this.label_imc.TabIndex = 27;
            this.label_imc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exercicio19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 337);
            this.Controls.Add(this.label_imc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_peso);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio19";
            this.Text = "Exercicio19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_peso;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.Label label_imc;
    }
}