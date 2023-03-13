namespace Exercicios01_1_29.WinForms
{
    partial class Exercicio29
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
            this.label_titulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel_tabuada = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // button_calcular
            // 
            this.button_calcular.Location = new System.Drawing.Point(521, 330);
            this.button_calcular.Name = "button_calcular";
            this.button_calcular.Size = new System.Drawing.Size(80, 26);
            this.button_calcular.TabIndex = 38;
            this.button_calcular.Text = "Gerar";
            this.button_calcular.UseVisualStyleBackColor = true;
            this.button_calcular.Click += new System.EventHandler(this.button_calcular_Click);
            // 
            // label_titulo
            // 
            this.label_titulo.AutoSize = true;
            this.label_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titulo.Location = new System.Drawing.Point(507, 9);
            this.label_titulo.Name = "label_titulo";
            this.label_titulo.Size = new System.Drawing.Size(104, 25);
            this.label_titulo.TabIndex = 41;
            this.label_titulo.Text = "Tabuada";
            this.label_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel_tabuada
            // 
            this.tableLayoutPanel_tabuada.ColumnCount = 10;
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel_tabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel_tabuada.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel_tabuada.Location = new System.Drawing.Point(12, 55);
            this.tableLayoutPanel_tabuada.Name = "tableLayoutPanel_tabuada";
            this.tableLayoutPanel_tabuada.RowCount = 1;
            this.tableLayoutPanel_tabuada.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_tabuada.Size = new System.Drawing.Size(1096, 269);
            this.tableLayoutPanel_tabuada.TabIndex = 42;
            // 
            // Exercicio29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 370);
            this.Controls.Add(this.tableLayoutPanel_tabuada);
            this.Controls.Add(this.label_titulo);
            this.Controls.Add(this.button_calcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Exercicio29";
            this.Text = "Exercicio29";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_calcular;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_tabuada;
    }
}