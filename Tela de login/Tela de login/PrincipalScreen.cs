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
    public partial class PrincipalScreen : Form
    {
        public PrincipalScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mensagem de confirmação ao clicar no botão.
            var msg = MessageBox.Show("Tem certeza que deseja deslogar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (msg == DialogResult.Yes) //Se o usuário clicou em sim.
            {
                this.Close(); //Fecha a janela atual.
                LoginScreen j2 = new LoginScreen(); //Instância da tela de login no objeto j2.
                j2.Show(); //Mostra a janela de login.
            }
        }
    }
}
