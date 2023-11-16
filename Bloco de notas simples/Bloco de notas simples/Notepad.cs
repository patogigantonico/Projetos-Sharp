using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Bloco_de_notas_simples
{
    public partial class Notepad : Form
    {

        Configurações cfg = new Configurações(); //Instância global da classe que contém os métodos necessário para o funcionamento do aplicativo.

        public Notepad()
        {
            InitializeComponent();
        }

        private void sairDoAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //Fecha o formulário.
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cfg.AbrirArquivoTexto(txtdiguser); //Método que abre o arquivo.
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cfg.SalvarArquivo(txtdiguser.Text); //Método que salva o arquivo com tudo o que foi digitado.
        }

        //Abre a janela de edição de fonte.
        private void editarFonteETamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editar_fontes ed = new Editar_fontes();
            ed.Show();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            if (Configurações.atualizou == true) //Se o usuário acabou de atualizar.
            {
                //Atualiza a fonte.
                txtdiguser.Font = new Font(Configurações.Fonte, Configurações.Tamanho);
                txtdiguser.ForeColor = (Color)Configurações.Cor; //Converte para o formato de cor.
                Configurações.atualizou = false; //Indica que o usuário não atualizou.
            }
        }

        //Ao fechar o bloco de notas.
        private void Notepad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
