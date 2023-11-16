namespace Bloco_de_notas_simples
{
    partial class Editar_fontes
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
            this.label1 = new System.Windows.Forms.Label();
            this.font = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tamanho = new System.Windows.Forms.TextBox();
            this.cor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fonte";
            // 
            // font
            // 
            this.font.FormattingEnabled = true;
            this.font.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Comic Sans",
            "Verdana",
            "Impact"});
            this.font.Location = new System.Drawing.Point(17, 37);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(226, 21);
            this.font.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamanho";
            // 
            // tamanho
            // 
            this.tamanho.Location = new System.Drawing.Point(17, 88);
            this.tamanho.Name = "tamanho";
            this.tamanho.Size = new System.Drawing.Size(226, 20);
            this.tamanho.TabIndex = 4;
            this.tamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tamanho_KeyPress);
            // 
            // cor
            // 
            this.cor.FormattingEnabled = true;
            this.cor.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Orange",
            "Black",
            "White",
            "Yellow"});
            this.cor.Location = new System.Drawing.Point(17, 134);
            this.cor.Name = "cor";
            this.cor.Size = new System.Drawing.Size(226, 21);
            this.cor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cor";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(17, 161);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(226, 23);
            this.btnAplicar.TabIndex = 7;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // Editar_fontes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 193);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cor);
            this.Controls.Add(this.tamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.font);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Editar_fontes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Fontes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Editar_fontes_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox font;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tamanho;
        private System.Windows.Forms.ComboBox cor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAplicar;
    }
}