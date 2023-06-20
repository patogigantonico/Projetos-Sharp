namespace Bloco_de_notas_simples
{
    partial class Notepad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtdiguser = new System.Windows.Forms.TextBox();
            this.editarFonteETamanhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarFonteETamanhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarComoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairDoAplicativoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salvarComoToolStripMenuItem.Text = "&Salvar como..";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.abrirToolStripMenuItem.Text = "&Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // sairDoAplicativoToolStripMenuItem
            // 
            this.sairDoAplicativoToolStripMenuItem.Name = "sairDoAplicativoToolStripMenuItem";
            this.sairDoAplicativoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sairDoAplicativoToolStripMenuItem.Text = "Sair do aplicativo";
            this.sairDoAplicativoToolStripMenuItem.Click += new System.EventHandler(this.sairDoAplicativoToolStripMenuItem_Click);
            // 
            // txtdiguser
            // 
            this.txtdiguser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtdiguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtdiguser.Location = new System.Drawing.Point(0, 24);
            this.txtdiguser.Multiline = true;
            this.txtdiguser.Name = "txtdiguser";
            this.txtdiguser.Size = new System.Drawing.Size(532, 261);
            this.txtdiguser.TabIndex = 1;
            // 
            // editarFonteETamanhoToolStripMenuItem
            // 
            this.editarFonteETamanhoToolStripMenuItem.Name = "editarFonteETamanhoToolStripMenuItem";
            this.editarFonteETamanhoToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.editarFonteETamanhoToolStripMenuItem.Text = "&Editar fonte e tamanho";
            this.editarFonteETamanhoToolStripMenuItem.Click += new System.EventHandler(this.editarFonteETamanhoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 285);
            this.Controls.Add(this.txtdiguser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bloco de notas simples";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairDoAplicativoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtdiguser;
        private System.Windows.Forms.ToolStripMenuItem editarFonteETamanhoToolStripMenuItem;
    }
}

