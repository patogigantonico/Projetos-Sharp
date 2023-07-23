namespace Aplicativo_signos
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnQualémeusig = new System.Windows.Forms.Button();
            this.LblSigno = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.descSigno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o dia e o mês de seu nascimento (DD/MM).\r\n";
            // 
            // btnQualémeusig
            // 
            this.btnQualémeusig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQualémeusig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualémeusig.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQualémeusig.Location = new System.Drawing.Point(12, 92);
            this.btnQualémeusig.Name = "btnQualémeusig";
            this.btnQualémeusig.Size = new System.Drawing.Size(390, 39);
            this.btnQualémeusig.TabIndex = 2;
            this.btnQualémeusig.Text = "Qual é o meu signo?";
            this.btnQualémeusig.UseVisualStyleBackColor = false;
            this.btnQualémeusig.Click += new System.EventHandler(this.btnQualémeusig_Click);
            // 
            // LblSigno
            // 
            this.LblSigno.AutoSize = true;
            this.LblSigno.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSigno.Location = new System.Drawing.Point(103, 134);
            this.LblSigno.Name = "LblSigno";
            this.LblSigno.Size = new System.Drawing.Size(178, 26);
            this.LblSigno.TabIndex = 4;
            this.LblSigno.Text = "Nome do signo aqui";
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtMes.Location = new System.Drawing.Point(75, 54);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(52, 32);
            this.txtMes.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(72, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mês";
            // 
            // txtDia
            // 
            this.txtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.txtDia.Location = new System.Drawing.Point(17, 54);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(52, 32);
            this.txtDia.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Dia";
            // 
            // descSigno
            // 
            this.descSigno.Location = new System.Drawing.Point(108, 163);
            this.descSigno.Multiline = true;
            this.descSigno.Name = "descSigno";
            this.descSigno.ReadOnly = true;
            this.descSigno.Size = new System.Drawing.Size(173, 95);
            this.descSigno.TabIndex = 15;
            this.descSigno.Text = "Descrição do signo aqui dentro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 266);
            this.Controls.Add(this.descSigno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.LblSigno);
            this.Controls.Add(this.btnQualémeusig);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qual seu signo?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQualémeusig;
        private System.Windows.Forms.Label LblSigno;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descSigno;
    }
}

