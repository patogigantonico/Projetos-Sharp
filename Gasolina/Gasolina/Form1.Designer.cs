namespace Gasolina
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
            this.NomeCarro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KMLitros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorLitro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Dinheiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QtdLitros = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QtdeKM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.RESULTADOS = new System.Windows.Forms.Label();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomeCarro
            // 
            this.NomeCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.NomeCarro.Location = new System.Drawing.Point(42, 59);
            this.NomeCarro.Name = "NomeCarro";
            this.NomeCarro.Size = new System.Drawing.Size(276, 44);
            this.NomeCarro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do veículo";
            // 
            // KMLitros
            // 
            this.KMLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.KMLitros.Location = new System.Drawing.Point(42, 149);
            this.KMLitros.Name = "KMLitros";
            this.KMLitros.Size = new System.Drawing.Size(276, 44);
            this.KMLitros.TabIndex = 2;
            this.KMLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressTextbox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "KM por litro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // ValorLitro
            // 
            this.ValorLitro.BackColor = System.Drawing.SystemColors.Info;
            this.ValorLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.ValorLitro.Location = new System.Drawing.Point(42, 322);
            this.ValorLitro.Name = "ValorLitro";
            this.ValorLitro.ReadOnly = true;
            this.ValorLitro.Size = new System.Drawing.Size(276, 44);
            this.ValorLitro.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(37, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor do Litro R$";
            // 
            // Dinheiro
            // 
            this.Dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.Dinheiro.Location = new System.Drawing.Point(46, 409);
            this.Dinheiro.Name = "Dinheiro";
            this.Dinheiro.Size = new System.Drawing.Size(276, 44);
            this.Dinheiro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dinheiro R$";
            // 
            // QtdLitros
            // 
            this.QtdLitros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.QtdLitros.BackColor = System.Drawing.SystemColors.Info;
            this.QtdLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.QtdLitros.Location = new System.Drawing.Point(363, 157);
            this.QtdLitros.Name = "QtdLitros";
            this.QtdLitros.ReadOnly = true;
            this.QtdLitros.Size = new System.Drawing.Size(276, 44);
            this.QtdLitros.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(419, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quant. Litros";
            // 
            // QtdeKM
            // 
            this.QtdeKM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.QtdeKM.BackColor = System.Drawing.SystemColors.Info;
            this.QtdeKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.QtdeKM.Location = new System.Drawing.Point(363, 238);
            this.QtdeKM.Name = "QtdeKM";
            this.QtdeKM.ReadOnly = true;
            this.QtdeKM.Size = new System.Drawing.Size(276, 44);
            this.QtdeKM.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(433, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quant. KM";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcular.BackColor = System.Drawing.Color.Green;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(337, 408);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(170, 45);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gasolina",
            "Etanol",
            "Gas. Aditivada"});
            this.comboBox1.Location = new System.Drawing.Point(42, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 45);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(734, 477);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape2.BackColor = System.Drawing.Color.Red;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape2.BorderWidth = 2;
            this.rectangleShape2.Location = new System.Drawing.Point(337, 59);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(325, 242);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BorderColor = System.Drawing.Color.Black;
            this.rectangleShape1.Location = new System.Drawing.Point(26, 20);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(690, 445);
            // 
            // RESULTADOS
            // 
            this.RESULTADOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RESULTADOS.AutoSize = true;
            this.RESULTADOS.BackColor = System.Drawing.Color.Red;
            this.RESULTADOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULTADOS.ForeColor = System.Drawing.Color.White;
            this.RESULTADOS.Location = new System.Drawing.Point(389, 72);
            this.RESULTADOS.Name = "RESULTADOS";
            this.RESULTADOS.Size = new System.Drawing.Size(209, 31);
            this.RESULTADOS.TabIndex = 17;
            this.RESULTADOS.Text = "RESULTADOS";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpar.BackColor = System.Drawing.Color.SlateGray;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(513, 408);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(194, 45);
            this.BtnLimpar.TabIndex = 18;
            this.BtnLimpar.Text = "Limpar tudo";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(355, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 43);
            this.label8.TabIndex = 19;
            this.label8.Text = "BY: PATOGIGANTONICO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(734, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.RESULTADOS);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.QtdeKM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QtdLitros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dinheiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ValorLitro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KMLitros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeCarro);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Bomba de combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeCarro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KMLitros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValorLitro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dinheiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox QtdLitros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QtdeKM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label RESULTADOS;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label label8;
    }
}

