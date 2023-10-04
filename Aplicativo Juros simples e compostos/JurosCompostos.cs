using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicativo_Juros_simples_e_compostos
{
    public partial class JurosCompostos : UserControl
    {
        Classes.JurosCompostos comp = new Classes.JurosCompostos();//Instância da classe que possui os métodos para calcular juros compostos.

        public JurosCompostos()
        {
            InitializeComponent();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            this.SendToBack(); //Faz essa tela ir para trás
            this.Visible = false; //Faz essa tela ficar invisível
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Verifica se as caixas de texto estão vazias e mostra a mensagem caso estejam ou uma delas estejam.
            if (string.IsNullOrEmpty(txtCapit.Text) || string.IsNullOrEmpty(txtTax.Text) || string.IsNullOrEmpty(txtTemp.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                try//Tenta executar o que está dentro dele.
                {
                    //Atribui os valores digitados às variáveis e converte para double.
                    comp.capital = double.Parse(txtCapit.Text);
                    comp.taxa = double.Parse(txtTax.Text);
                    comp.tempo = double.Parse(txtTemp.Text);

                    comp.CalcularJurosComp(); //Chama o método que calcula os valores inseridos nas variáveis.
                    txtResult.Text = comp.Result().ToString(); //Exibe o resultado do calculo na txtbox.
                }
                catch(FormatException ex) //Captura e informa o erro em uma mensagem.
                {
                    MessageBox.Show(ex.Message, "Ocorreu um erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Limpa as txtbox.
                    txtCapit.Text = "";
                    txtTax.Text = "";
                    txtTemp.Text = "";

                }
            }
        }
    }
}
