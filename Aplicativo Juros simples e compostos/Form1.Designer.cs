namespace Aplicativo_Juros_simples_e_compostos
{
    partial class Form1
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
            this.txtCapit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnMode = new System.Windows.Forms.Button();
            this.jurosCompostos1 = new Aplicativo_Juros_simples_e_compostos.JurosCompostos();
            this.SuspendLayout();
            // 
            // txtCapit
            // 
            this.txtCapit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCapit.Location = new System.Drawing.Point(15, 59);
            this.txtCapit.Name = "txtCapit";
            this.txtCapit.Size = new System.Drawing.Size(142, 26);
            this.txtCapit.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Taxa";
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTax.Location = new System.Drawing.Point(15, 111);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(142, 26);
            this.txtTax.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Capital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(11, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(170, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado";
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTemp.Location = new System.Drawing.Point(15, 163);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(142, 26);
            this.txtTemp.TabIndex = 7;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtResult.Location = new System.Drawing.Point(174, 59);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(98, 130);
            this.txtResult.TabIndex = 8;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 195);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(257, 23);
            this.btnCalc.TabIndex = 10;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(61, 224);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(158, 23);
            this.btnMode.TabIndex = 0;
            this.btnMode.Text = "Mudar para Juros Compostos";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // jurosCompostos1
            // 
            this.jurosCompostos1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.jurosCompostos1.Location = new System.Drawing.Point(0, -2);
            this.jurosCompostos1.Name = "jurosCompostos1";
            this.jurosCompostos1.Size = new System.Drawing.Size(286, 263);
            this.jurosCompostos1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtCapit);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.jurosCompostos1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Juros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnMode;
        private JurosCompostos jurosCompostos1;





    }
}

