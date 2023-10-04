namespace Aplicativo_Juros_simples_e_compostos
{
    partial class JurosCompostos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapit = new System.Windows.Forms.TextBox();
            this.btnMode = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 195);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(247, 23);
            this.btnCalc.TabIndex = 20;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(160, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtResult.Location = new System.Drawing.Point(164, 62);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(98, 130);
            this.txtResult.TabIndex = 18;
            // 
            // txtTax
            // 
            this.txtTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTax.Location = new System.Drawing.Point(16, 114);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(142, 26);
            this.txtTax.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Taxa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(11, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Capital";
            // 
            // txtCapit
            // 
            this.txtCapit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCapit.Location = new System.Drawing.Point(15, 62);
            this.txtCapit.Name = "txtCapit";
            this.txtCapit.Size = new System.Drawing.Size(142, 26);
            this.txtCapit.TabIndex = 13;
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(16, 224);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(246, 23);
            this.btnMode.TabIndex = 11;
            this.btnMode.Text = "Mudar para Juros Simples";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTemp.Location = new System.Drawing.Point(16, 166);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(142, 26);
            this.txtTemp.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tempo";
            // 
            // JurosCompostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCapit);
            this.Controls.Add(this.btnMode);
            this.Name = "JurosCompostos";
            this.Size = new System.Drawing.Size(283, 263);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapit;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label1;

    }
}
