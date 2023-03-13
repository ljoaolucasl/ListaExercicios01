namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio13
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
            this.textBox_broa = new System.Windows.Forms.TextBox();
            this.textBox_pao = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.textBox_fundo = new System.Windows.Forms.TextBox();
            this.label_broa = new System.Windows.Forms.Label();
            this.label_pao = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_guarda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_paoTotal = new System.Windows.Forms.Label();
            this.label_broaTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(37, 213);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 3;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // textBox_broa
            // 
            this.textBox_broa.Location = new System.Drawing.Point(19, 162);
            this.textBox_broa.MaxLength = 6;
            this.textBox_broa.Name = "textBox_broa";
            this.textBox_broa.Size = new System.Drawing.Size(98, 20);
            this.textBox_broa.TabIndex = 2;
            this.textBox_broa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pao_KeyPress);
            // 
            // textBox_pao
            // 
            this.textBox_pao.Location = new System.Drawing.Point(19, 99);
            this.textBox_pao.MaxLength = 6;
            this.textBox_pao.Name = "textBox_pao";
            this.textBox_pao.Size = new System.Drawing.Size(98, 20);
            this.textBox_pao.TabIndex = 1;
            this.textBox_pao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pao_KeyPress);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(77, 23);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(175, 25);
            this.label_titulo.TabIndex = 9;
            this.label_titulo.Text = "Padaria Hotpão";
            // 
            // textBox_fundo
            // 
            this.textBox_fundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox_fundo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_fundo.Enabled = false;
            this.textBox_fundo.Location = new System.Drawing.Point(-1, -3);
            this.textBox_fundo.Multiline = true;
            this.textBox_fundo.Name = "textBox_fundo";
            this.textBox_fundo.Size = new System.Drawing.Size(336, 72);
            this.textBox_fundo.TabIndex = 15;
            // 
            // label_broa
            // 
            this.label_broa.AutoSize = true;
            this.label_broa.Location = new System.Drawing.Point(20, 146);
            this.label_broa.Name = "label_broa";
            this.label_broa.Size = new System.Drawing.Size(29, 13);
            this.label_broa.TabIndex = 17;
            this.label_broa.Text = "Broa";
            // 
            // label_pao
            // 
            this.label_pao.AutoSize = true;
            this.label_pao.Location = new System.Drawing.Point(20, 83);
            this.label_pao.Name = "label_pao";
            this.label_pao.Size = new System.Drawing.Size(51, 13);
            this.label_pao.TabIndex = 16;
            this.label_pao.Text = "Pãozinho";
            // 
            // label_total
            // 
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(169, 101);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(152, 47);
            this.label_total.TabIndex = 18;
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_guarda
            // 
            this.label_guarda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_guarda.Location = new System.Drawing.Point(169, 164);
            this.label_guarda.Name = "label_guarda";
            this.label_guarda.Size = new System.Drawing.Size(152, 53);
            this.label_guarda.TabIndex = 19;
            this.label_guarda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "quant.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "quant.";
            // 
            // label_paoTotal
            // 
            this.label_paoTotal.Location = new System.Drawing.Point(169, 72);
            this.label_paoTotal.Name = "label_paoTotal";
            this.label_paoTotal.Size = new System.Drawing.Size(83, 13);
            this.label_paoTotal.TabIndex = 22;
            this.label_paoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_broaTotal
            // 
            this.label_broaTotal.Location = new System.Drawing.Point(169, 85);
            this.label_broaTotal.Name = "label_broaTotal";
            this.label_broaTotal.Size = new System.Drawing.Size(83, 13);
            this.label_broaTotal.TabIndex = 23;
            this.label_broaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Exercicio13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.label_broaTotal);
            this.Controls.Add(this.label_paoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_guarda);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_broa);
            this.Controls.Add(this.label_pao);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.textBox_broa);
            this.Controls.Add(this.textBox_pao);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.textBox_fundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio13";
            this.Text = "Exercicio13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.TextBox textBox_broa;
        private System.Windows.Forms.TextBox textBox_pao;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TextBox textBox_fundo;
        private System.Windows.Forms.Label label_broa;
        private System.Windows.Forms.Label label_pao;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_guarda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_paoTotal;
        private System.Windows.Forms.Label label_broaTotal;
    }
}