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
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close(); //Fecha a janela atual
            LoginScreen j2 = new LoginScreen(); //Instância da tela de login no objeto j2.
            j2.Show(); //Mostra a janela de login.
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Mostra a mensagem ao clicar.
            MessageBox.Show("Em breve!");
        }
    }
}
