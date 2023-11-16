using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Campo_Minado
{
    public partial class Jogo : Form
    {
        //Variáveis.
        int bomba = 0; //Variável responsável por dizer qual botão vai ser a bomba.
        int pontos = 0; //Variável responsável por armazenar os pontos.
        int botao = 8; //Variável que contém os botões máximos que podem ser pressionados.
        int botoesPressionados = 1; //Variável que contém os botões que foram pressionados.
        //Esta variavel contém o valor 1 porque o máximo de botões necessários para vencer é 9, ou seja 1 deles é a bomba.

        //Instância da classe random para gerar uma pontuação aleatória.
        Random rnd = new Random();
        

        public Jogo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarJogo(); //Inicia o método assim que o programa é aberto.

            //Remove o destaque ao clicar em um botão
            b11.TabStop = false;
            b12.TabStop = false;
            b13.TabStop = false;
            b21.TabStop = false;
            b22.TabStop = false;
            b23.TabStop = false;
            b31.TabStop = false;
            b32.TabStop = false;
            b33.TabStop = false;
        }

        private void IniciarJogo() //Inicia o jogo com método GerarBombas.
        {
            GerarBombas();
            VerificarVitória();
        }

        private void GerarBombas()//Gera as bombas do tabuleiro.
        {
            foreach (Control btns in this.Controls) //Para cada controle deste formulário faça.
            {
                if (btns is Button && btns != pictureBox1 && btns != lblPoints && btns != QuantPontos) //Se btns for um botão e não for picturebox1, lblpoints, quantpontos faça.
                {
                    bomba = new Random().Next(this.Controls.OfType<Button>().Count()); //A variável bomba recebe o valor gerado aleatoriamente dos botões com base na quantidade de botões deste formulário.
                        switch (bomba) //Atribui o valor de bomba com base no valor da variável bomba.
                        {
                            case 0:
                                b11.Text = "Bomba";
                                break;

                            case 1:
                                b12.Text = "Bomba";
                                break;

                            case 2:
                                b13.Text = "Bomba";
                                break;

                            case 3:
                                b21.Text = "Bomba";
                                break;

                            case 4:
                                b22.Text = "Bomba";
                                break;

                            case 5:
                                b23.Text = "Bomba";
                                VerificarVitória();
                                break;

                            case 6:
                                b31.Text = "Bomba";
                                break;

                            case 7:
                                b32.Text = "Bomba";
                                break;

                            case 8:
                                b33.Text = "Bomba";
                                break;

                            default:
                                Application.Restart();
                                break;
                           
                        }
                        break;

                        
                            
                        
                }
            }
        }

        private void ReiniciarJogo() //Reinicia o jogo assim que o jogador clica em uma bomba.
        {
            Control[] botao = this.Controls.OfType<Control>().Where(b => b != pictureBox1 && b != lblPoints && b != QuantPontos).ToArray();

            foreach (Control botoes in botao) 
            {
                if (botoes is Button && botoes != pictureBox1 && botoes != lblPoints && botoes != QuantPontos) 
                {
                    GerarBombas(); //Iniciar novamente o jogo.

                    //Limpa o txt dos botões e os ativa novamente.
                    botoes.Text = "";
                    botoes.Enabled = true;
                    botoes.BackColor = Color.DeepPink;
                    

                    QuantPontos.Text = "0"; //Zera a label.
                    pontos = 0;//Zera os pontos
                }
            }
        }

        private void VerificarVitória() //Verifica se o jogador pressionou todos os botões exceto o que possui "Bomba". 
        {
            Control[] botoes = this.Controls.OfType<Control>().Where(b => b != pictureBox1 && b != lblPoints && b != QuantPontos).ToArray();

            foreach (Control btns in botoes)
            {
                if (botao == botoesPressionados) 
                {
                    MessageBox.Show("Você venceu!", "Venceu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    botoesPressionados = 0;
                    ReiniciarJogo();
                }
            }
        }

        private void PressionarBotao(Button botao) //Evento de click para todos os botões.
{
    if (botao.Text == "Bomba") //Se o user clicou no botão com texto bomba, mostra a mensagem e reinicia o jogo.
    {
        MessageBox.Show("Você encontrou a bomba!", "Você perdeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ReiniciarJogo();
    }
    else
    {
        Random pontosAleatórios = new Random();
        botao.Enabled = false;
        botao.BackColor = Color.Gray;
        pontos += pontosAleatórios.Next(50000);
        QuantPontos.Text = pontos.ToString();
        VerificarVitória();
        botoesPressionados++;
    }
} 

        
        //Todos os botões recebem os parâmetros do método PressionarBotão.
        private void b11_Click(object sender, EventArgs e)
        {
            PressionarBotao(b11);
        }

        private void b12_Click(object sender, EventArgs e)
        {
            PressionarBotao(b12);
        }

        private void b13_Click(object sender, EventArgs e)
        {
            PressionarBotao(b13);
        }

        private void b21_Click(object sender, EventArgs e)
        {
            PressionarBotao(b21);
        }

        private void b22_Click(object sender, EventArgs e)
        {
            PressionarBotao(b22);
        }

        private void b23_Click(object sender, EventArgs e)
        {
            PressionarBotao(b23);
        }

        private void b31_Click(object sender, EventArgs e)
        {
            PressionarBotao(b31);
        }

        private void b32_Click(object sender, EventArgs e)
        {
            PressionarBotao(b32);
        }

        private void b33_Click(object sender, EventArgs e)
        {
            PressionarBotao(b33);
        }
    }
}
