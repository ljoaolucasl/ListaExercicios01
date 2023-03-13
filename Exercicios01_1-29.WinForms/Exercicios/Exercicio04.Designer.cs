namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio04
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
            this.label_consumo = new System.Windows.Forms.Label();
            this.textBox_consumo = new System.Windows.Forms.TextBox();
            this.label_kmFinal = new System.Windows.Forms.Label();
            this.textBox_kmFinal = new System.Windows.Forms.TextBox();
            this.label_kmInicial = new System.Windows.Forms.Label();
            this.textBox_kmInicial = new System.Windows.Forms.TextBox();
            this.label_titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_resultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(39, 269);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 4;
            this.button_calcular.Text = "Calcular";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_consumo
            // 
            this.label_consumo.AutoSize = true;
            this.label_consumo.Location = new System.Drawing.Point(22, 210);
            this.label_consumo.Name = "label_consumo";
            this.label_consumo.Size = new System.Drawing.Size(154, 13);
            this.label_consumo.TabIndex = 15;
            this.label_consumo.Text = "Consumo de Combustível(Litro)";
            // 
            // textBox_consumo
            // 
            this.textBox_consumo.Location = new System.Drawing.Point(21, 229);
            this.textBox_consumo.MaxLength = 7;
            this.textBox_consumo.Name = "textBox_consumo";
            this.textBox_consumo.Size = new System.Drawing.Size(118, 20);
            this.textBox_consumo.TabIndex = 3;
            this.textBox_consumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kmInicial_KeyPress);
            // 
            // label_kmFinal
            // 
            this.label_kmFinal.AutoSize = true;
            this.label_kmFinal.Location = new System.Drawing.Point(22, 146);
            this.label_kmFinal.Name = "label_kmFinal";
            this.label_kmFinal.Size = new System.Drawing.Size(48, 13);
            this.label_kmFinal.TabIndex = 13;
            this.label_kmFinal.Text = "km/Final";
            // 
            // textBox_kmFinal
            // 
            this.textBox_kmFinal.Location = new System.Drawing.Point(21, 165);
            this.textBox_kmFinal.MaxLength = 7;
            this.textBox_kmFinal.Name = "textBox_kmFinal";
            this.textBox_kmFinal.Size = new System.Drawing.Size(118, 20);
            this.textBox_kmFinal.TabIndex = 2;
            this.textBox_kmFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kmInicial_KeyPress);
            // 
            // label_kmInicial
            // 
            this.label_kmInicial.AutoSize = true;
            this.label_kmInicial.Location = new System.Drawing.Point(22, 83);
            this.label_kmInicial.Name = "label_kmInicial";
            this.label_kmInicial.Size = new System.Drawing.Size(53, 13);
            this.label_kmInicial.TabIndex = 11;
            this.label_kmInicial.Text = "km/Inicial";
            // 
            // textBox_kmInicial
            // 
            this.textBox_kmInicial.Location = new System.Drawing.Point(21, 102);
            this.textBox_kmInicial.MaxLength = 7;
            this.textBox_kmInicial.Name = "textBox_kmInicial";
            this.textBox_kmInicial.Size = new System.Drawing.Size(118, 20);
            this.textBox_kmInicial.TabIndex = 1;
            this.textBox_kmInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kmInicial_KeyPress);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(16, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(380, 50);
            this.label_titulo.TabIndex = 9;
            this.label_titulo.Text = "Calcular Consumo de Combustível \r\npor km";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Exercicios01_1_29.WinForms.Properties.Resources.consumokm;
            this.pictureBox1.Location = new System.Drawing.Point(214, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label_resultado
            // 
            this.label_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_resultado.Location = new System.Drawing.Point(214, 97);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(143, 24);
            this.label_resultado.TabIndex = 18;
            this.label_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exercicio04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 312);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_calcular);
            this.Controls.Add(this.label_consumo);
            this.Controls.Add(this.textBox_consumo);
            this.Controls.Add(this.label_kmFinal);
            this.Controls.Add(this.textBox_kmFinal);
            this.Controls.Add(this.label_kmInicial);
            this.Controls.Add(this.textBox_kmInicial);
            this.Controls.Add(this.label_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio04";
            this.Text = "Exercicio04";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_consumo;
        private System.Windows.Forms.TextBox textBox_consumo;
        private System.Windows.Forms.Label label_kmFinal;
        private System.Windows.Forms.TextBox textBox_kmFinal;
        private System.Windows.Forms.Label label_kmInicial;
        private System.Windows.Forms.TextBox textBox_kmInicial;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_resultado;
    }
}