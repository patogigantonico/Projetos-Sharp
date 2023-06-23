namespace Gerador_de_números
{
    partial class Programa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Programa));
            this.dado = new System.Windows.Forms.PictureBox();
            this.NumMinimo = new System.Windows.Forms.TextBox();
            this.NumMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumGerado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dado)).BeginInit();
            this.SuspendLayout();
            // 
            // dado
            // 
            this.dado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dado.BackColor = System.Drawing.Color.Transparent;
            this.dado.Image = ((System.Drawing.Image)(resources.GetObject("dado.Image")));
            this.dado.Location = new System.Drawing.Point(207, 169);
            this.dado.Name = "dado";
            this.dado.Size = new System.Drawing.Size(107, 83);
            this.dado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dado.TabIndex = 0;
            this.dado.TabStop = false;
            this.dado.Click += new System.EventHandler(this.dado_Click);
            // 
            // NumMinimo
            // 
            this.NumMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NumMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.NumMinimo.Location = new System.Drawing.Point(132, 71);
            this.NumMinimo.Name = "NumMinimo";
            this.NumMinimo.Size = new System.Drawing.Size(242, 32);
            this.NumMinimo.TabIndex = 1;
            // 
            // NumMax
            // 
            this.NumMax.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NumMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.NumMax.Location = new System.Drawing.Point(132, 131);
            this.NumMax.Name = "NumMax";
            this.NumMax.Size = new System.Drawing.Size(242, 32);
            this.NumMax.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mínimo";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Máximo";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(129, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insira o valor mínimo e o valor máximo e clique no dado.";
            // 
            // lblNumGerado
            // 
            this.lblNumGerado.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNumGerado.AutoSize = true;
            this.lblNumGerado.BackColor = System.Drawing.Color.Transparent;
            this.lblNumGerado.ForeColor = System.Drawing.Color.White;
            this.lblNumGerado.Location = new System.Drawing.Point(129, 264);
            this.lblNumGerado.Name = "lblNumGerado";
            this.lblNumGerado.Size = new System.Drawing.Size(83, 13);
            this.lblNumGerado.TabIndex = 6;
            this.lblNumGerado.Text = "Número gerado:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 302);
            this.Controls.Add(this.lblNumGerado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumMax);
            this.Controls.Add(this.NumMinimo);
            this.Controls.Add(this.dado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Programa";
            this.Text = "Gerador de números";
            this.Load += new System.EventHandler(this.Programa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dado;
        private System.Windows.Forms.TextBox NumMinimo;
        private System.Windows.Forms.TextBox NumMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumGerado;
        private System.Windows.Forms.Timer timer1;
    }
}

