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
        public Notepad()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de texto *.txt | *.txt*"; 
            ofd.ShowDialog(); //Abre a janela ao clicar no botão (sempre lembrar de colocar o nome da variável antes).

            if (string.IsNullOrEmpty(ofd.FileName) == false) 
            {
                try
                {
                    StreamReader str = new StreamReader(ofd.FileName, Encoding.Default);
                    txtdiguser.Text = str.ReadToEnd(); //Lê os caracteres do arquivo e repassa para txtbox
                }
                catch (Exception ex) //Retorna a mensagem de erro caso não consiga abrir o arquivo. 
                {
                   MessageBox.Show(ex.Message, "Não foi possível abrir o arquivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void sairDoAplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivos de texto *.txt | *.txt";
            sfd.ShowDialog(); //Abre a janela ao clicar no botão (sempre lembrar de colocar o nome da variável antes).
            if (string.IsNullOrEmpty(sfd.FileName) == false) 
            {
                try
                {
                    
                    StreamWriter writer = new StreamWriter(sfd.FileName); //Salva o arquivo com o nome digitado pelo user.
                    writer.WriteLine(txtdiguser.Text); //Salva o texto escrito pelo usuário.
                    MessageBox.Show("Salvo com sucesso!!"); //Mostra mensagem de salvo para o usuário.
                    writer.Flush();// Deleta da memória ram os dados adquiridos antes.
                    
                }
                catch(Exception ex) //Retorna a mensagem de erro caso não consiga salvar o arquivo. 
                {
                    MessageBox.Show(ex.Message, "Não foi possível salvar o arquivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }
            }
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarFonteETamanhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar_fonte j2 = new Editar_fonte();
            j2.Show();
        }
    }
}
