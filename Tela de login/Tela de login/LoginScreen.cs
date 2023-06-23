using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tela_de_login
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Se o texto digitado na caixa de username não for admin
            if (txtUser.Text != "admin" && txtSenha.Text != "senha")
            {
                //Mostra a mensagem
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                this.Hide();//Esconde a janela atual
                PrincipalScreen j2 = new PrincipalScreen(); //Instância da janela principal no objeto j2.
                j2.Show();
            }
        }

        private void linkCadastr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); //Esconde a janela atual
            RegisterScreen j2 = new RegisterScreen(); //Instância da janela de registro no objeto j2.
            j2.Show(); //Mostra a janela de registro.
        }
    }
}
