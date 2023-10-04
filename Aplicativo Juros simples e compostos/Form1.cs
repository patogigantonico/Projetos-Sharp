using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Aplicativo_Juros_simples_e_compostos
{
    public partial class Form1 : Form
    {
        bool clicou = false;
        JurosSimples JrSimp = new JurosSimples(); //Instância da classe que faz todos os calculos de juros simples.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jurosCompostos1.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Caso as caixas estiverem vazias, mostrar a mensagem.
            if (string.IsNullOrEmpty(txtCapit.Text) || string.IsNullOrEmpty(txtTax.Text) || string.IsNullOrEmpty(txtTemp.Text))
            {
                MessageBox.Show("Você precisa preencher todos os campos antes de continuar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try //Tenta executar os comandos abaixo.
                {
                    //As variáveis da classe recebem os valores digitados pelo user e depois converte para decimal.
                    JrSimp.capital = double.Parse(txtCapit.Text);
                    JrSimp.taxa = double.Parse(txtTax.Text);
                    JrSimp.tempo = double.Parse(txtTemp.Text);

                    JrSimp.CalcJurosSimples(); //Executa o método que calcula os valores das variáveis
                    txtResult.Text = JrSimp.ResultJuros().ToString(); //Executa o método que mostra o resultado.

                    //Limpa as caixas de texto para o usuário.
                    txtCapit.Text = string.Empty;
                    txtTax.Text = string.Empty;
                    txtTemp.Text = string.Empty;
                }
                catch (FormatException ex) //Captura o erro e mostra na mensagem caso algo falhe, impedindo que o programa pare de funcionar.
                {
                    MessageBox.Show(ex.Message, "Ocorreu um erro inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            if (clicou == false)
            {
                jurosCompostos1.BringToFront();
                jurosCompostos1.Visible = true;
                clicou = false;
            }
        }
    }
}
