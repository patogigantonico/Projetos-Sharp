namespace JogodaForca
{
    partial class Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            this.letra1 = new System.Windows.Forms.Label();
            this.letra2 = new System.Windows.Forms.Label();
            this.letra3 = new System.Windows.Forms.Label();
            this.letra4 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.ContErros = new System.Windows.Forms.Label();
            this.lblVitorias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forca = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.forca)).BeginInit();
            this.SuspendLayout();
            // 
            // letra1
            // 
            this.letra1.AutoSize = true;
            this.letra1.BackColor = System.Drawing.Color.Transparent;
            this.letra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.letra1.ForeColor = System.Drawing.Color.White;
            this.letra1.Location = new System.Drawing.Point(2, 9);
            this.letra1.Name = "letra1";
            this.letra1.Size = new System.Drawing.Size(68, 74);
            this.letra1.TabIndex = 0;
            this.letra1.Text = "L";
            // 
            // letra2
            // 
            this.letra2.AutoSize = true;
            this.letra2.BackColor = System.Drawing.Color.Transparent;
            this.letra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.letra2.ForeColor = System.Drawing.Color.White;
            this.letra2.Location = new System.Drawing.Point(81, 9);
            this.letra2.Name = "letra2";
            this.letra2.Size = new System.Drawing.Size(75, 74);
            this.letra2.TabIndex = 1;
            this.letra2.Text = "E";
            // 
            // letra3
            // 
            this.letra3.AutoSize = true;
            this.letra3.BackColor = System.Drawing.Color.Transparent;
            this.letra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.letra3.ForeColor = System.Drawing.Color.White;
            this.letra3.Location = new System.Drawing.Point(162, 9);
            this.letra3.Name = "letra3";
            this.letra3.Size = new System.Drawing.Size(72, 74);
            this.letra3.TabIndex = 2;
            this.letra3.Text = "T";
            // 
            // letra4
            // 
            this.letra4.AutoSize = true;
            this.letra4.BackColor = System.Drawing.Color.Transparent;
            this.letra4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.letra4.ForeColor = System.Drawing.Color.White;
            this.letra4.Location = new System.Drawing.Point(240, 9);
            this.letra4.Name = "letra4";
            this.letra4.Size = new System.Drawing.Size(79, 74);
            this.letra4.TabIndex = 3;
            this.letra4.Text = "R";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtPalavra.Location = new System.Drawing.Point(25, 218);
            this.txtPalavra.MaxLength = 4;
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(261, 32);
            this.txtPalavra.TabIndex = 4;
            this.txtPalavra.TextChanged += new System.EventHandler(this.txtPalavra_TextChanged);
            // 
            // ContErros
            // 
            this.ContErros.AutoSize = true;
            this.ContErros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ContErros.Location = new System.Drawing.Point(5, 253);
            this.ContErros.Name = "ContErros";
            this.ContErros.Size = new System.Drawing.Size(65, 24);
            this.ContErros.TabIndex = 6;
            this.ContErros.Text = "Erros: ";
            // 
            // lblVitorias
            // 
            this.lblVitorias.AutoSize = true;
            this.lblVitorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblVitorias.Location = new System.Drawing.Point(5, 277);
            this.lblVitorias.Name = "lblVitorias";
            this.lblVitorias.Size = new System.Drawing.Size(76, 24);
            this.lblVitorias.TabIndex = 7;
            this.lblVitorias.Text = "Vitórias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(56, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Digite aqui a palavra completa";
            // 
            // forca
            // 
            this.forca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forca.BackgroundImage")));
            this.forca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forca.Location = new System.Drawing.Point(59, 87);
            this.forca.Name = "forca";
            this.forca.Size = new System.Drawing.Size(188, 99);
            this.forca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forca.TabIndex = 9;
            this.forca.TabStop = false;
            // 
            // Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(318, 310);
            this.Controls.Add(this.forca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVitorias);
            this.Controls.Add(this.ContErros);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.letra4);
            this.Controls.Add(this.letra3);
            this.Controls.Add(this.letra2);
            this.Controls.Add(this.letra1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da forca";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.forca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label letra1;
        private System.Windows.Forms.Label letra2;
        private System.Windows.Forms.Label letra3;
        private System.Windows.Forms.Label letra4;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label ContErros;
        private System.Windows.Forms.Label lblVitorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox forca;

    }
}

