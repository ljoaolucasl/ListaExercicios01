namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio10
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
            this.label_nota2 = new System.Windows.Forms.Label();
            this.textBox_nota2 = new System.Windows.Forms.TextBox();
            this.label_nota1 = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.textBox_nota1 = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.listView_geral = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nota1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nota2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.media = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_nota2
            // 
            this.label_nota2.AutoSize = true;
            this.label_nota2.Location = new System.Drawing.Point(260, 228);
            this.label_nota2.Name = "label_nota2";
            this.label_nota2.Size = new System.Drawing.Size(103, 13);
            this.label_nota2.TabIndex = 23;
            this.label_nota2.Text = "Nota 2 (Matemática)";
            // 
            // textBox_nota2
            // 
            this.textBox_nota2.Location = new System.Drawing.Point(263, 244);
            this.textBox_nota2.MaxLength = 4;
            this.textBox_nota2.Name = "textBox_nota2";
            this.textBox_nota2.Size = new System.Drawing.Size(100, 20);
            this.textBox_nota2.TabIndex = 3;
            this.textBox_nota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nota1_KeyPress);
            // 
            // label_nota1
            // 
            this.label_nota1.AutoSize = true;
            this.label_nota1.Location = new System.Drawing.Point(145, 228);
            this.label_nota1.Name = "label_nota1";
            this.label_nota1.Size = new System.Drawing.Size(96, 13);
            this.label_nota1.TabIndex = 21;
            this.label_nota1.Text = "Nota 1 (Português)";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(20, 228);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(35, 13);
            this.label_nome.TabIndex = 20;
            this.label_nome.Text = "Nome";
            // 
            // textBox_nota1
            // 
            this.textBox_nota1.Location = new System.Drawing.Point(148, 244);
            this.textBox_nota1.MaxLength = 4;
            this.textBox_nota1.Name = "textBox_nota1";
            this.textBox_nota1.Size = new System.Drawing.Size(100, 20);
            this.textBox_nota1.TabIndex = 2;
            this.textBox_nota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nota1_KeyPress);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(23, 244);
            this.textBox_nome.MaxLength = 8;
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(100, 20);
            this.textBox_nome.TabIndex = 1;
            // 
            // listView_geral
            // 
            this.listView_geral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_geral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.nota1,
            this.nota2,
            this.media});
            this.listView_geral.GridLines = true;
            this.listView_geral.HideSelection = false;
            this.listView_geral.Location = new System.Drawing.Point(12, 12);
            this.listView_geral.Name = "listView_geral";
            this.listView_geral.Size = new System.Drawing.Size(369, 201);
            this.listView_geral.TabIndex = 18;
            this.listView_geral.TabStop = false;
            this.listView_geral.UseCompatibleStateImageBehavior = false;
            this.listView_geral.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 98;
            // 
            // nota1
            // 
            this.nota1.Text = "Português";
            this.nota1.Width = 56;
            // 
            // nota2
            // 
            this.nota2.Text = "Matemática";
            // 
            // media
            // 
            this.media.Text = "Média Ponderada";
            this.media.Width = 95;
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(274, 297);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Adicionar";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Português p3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Matemática p2";
            // 
            // Exercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_nota2);
            this.Controls.Add(this.textBox_nota2);
            this.Controls.Add(this.label_nota1);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_nota1);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.listView_geral);
            this.Controls.Add(this.button_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio10";
            this.Text = "Exercicio10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nota2;
        private System.Windows.Forms.TextBox textBox_nota2;
        private System.Windows.Forms.Label label_nota1;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox textBox_nota1;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.ListView listView_geral;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader nota1;
        private System.Windows.Forms.ColumnHeader nota2;
        private System.Windows.Forms.ColumnHeader media;
        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}