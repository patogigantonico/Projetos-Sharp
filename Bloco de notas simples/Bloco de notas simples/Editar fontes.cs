using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bloco_de_notas_simples
{
    public partial class Editar_fontes : Form
    {
        Notepad nt = new Notepad();

        public Editar_fontes()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            //Para cada controle deste formulário faça
            foreach (Control controle in this.Controls) 
            {
                //Se o texto de algum estiver vazio.
                if (controle.Text == string.Empty) 
                {
                    MessageBox.Show("Há campos a serem preenchidos!");
                    return;
                }
            }

            //Caso não preencha as variáveis.
            Configurações.Fonte = font.Text;
            Configurações.Cor = cor.Text;
            Configurações.VerificarCor(Configurações.Cor);
            Configurações.Tamanho = Convert.ToInt32(tamanho.Text);
            Configurações.atualizou = true;

            this.Close();
            nt.Show();
        }

        private void tamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Impede que o usuário digite letras, espaços, simbolos e sinais de pontuação.
            if (char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }

        private void Editar_fontes_FormClosed(object sender, FormClosedEventArgs e)
        {
            nt.Show();
        }
    }
}
