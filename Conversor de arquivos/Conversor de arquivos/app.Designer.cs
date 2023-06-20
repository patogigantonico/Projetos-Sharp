namespace Conversor_de_arquivos
{
    partial class app
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnSelecArq = new System.Windows.Forms.Button();
            this.listaFormatos = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(7, 109);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(248, 64);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(9, 37);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.ReadOnly = true;
            this.txtArquivo.Size = new System.Drawing.Size(440, 36);
            this.txtArquivo.TabIndex = 1;
            // 
            // btnSelecArq
            // 
            this.btnSelecArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSelecArq.Location = new System.Drawing.Point(455, 37);
            this.btnSelecArq.Name = "btnSelecArq";
            this.btnSelecArq.Size = new System.Drawing.Size(38, 35);
            this.btnSelecArq.TabIndex = 2;
            this.btnSelecArq.Text = "...";
            this.btnSelecArq.UseVisualStyleBackColor = true;
            this.btnSelecArq.Click += new System.EventHandler(this.btnSelecArq_Click);
            // 
            // listaFormatos
            // 
            this.listaFormatos.FormattingEnabled = true;
            this.listaFormatos.Items.AddRange(new object[] {
            "Pdf",
            "Docx",
            "Xlsx"});
            this.listaFormatos.Location = new System.Drawing.Point(263, 109);
            this.listaFormatos.Name = "listaFormatos";
            this.listaFormatos.Size = new System.Drawing.Size(230, 64);
            this.listaFormatos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caminho do arquivo selecionado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(261, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Converter o arquivo inserido para:";
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(502, 185);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaFormatos);
            this.Controls.Add(this.btnSelecArq);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.btnConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de arquivos";
            this.Load += new System.EventHandler(this.app_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnSelecArq;
        private System.Windows.Forms.CheckedListBox listaFormatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

