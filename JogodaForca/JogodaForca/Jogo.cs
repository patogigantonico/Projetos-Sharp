using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogodaForca
{
    public partial class Jogo : Form
    {
        int palavraEscolhid = 0; //Variável responsável por escolher a palavra no método GerarPalavra() e VerificarSeCorreta().   
        int erro = 0; //Variável responsável por contabilizar os erros.
        int vitorias = 0; //Variável responsável por contabilizar as vitórias.

        public Jogo()
        {
            InitializeComponent();
        }

        private void IniciarJogo() 
        {
            lblVitorias.Text = "Vitórias:" + vitorias;
            ContErros.Text = "Erros: " + erro;
            GerarPalavra();
        } //Executa todos os métodos necessários para iniciar o jogo.

        private void GerarPalavra() 
        {
            //Array com palavras para o jogo.
            string[] palavras = new string[10];
            palavras[0] = "Sina";
            palavras[1] = "Casa";
            palavras[2] = "Fogo";
            palavras[3] = "Loja";
            palavras[4] = "Urso";
            palavras[5] = "Seda";
            palavras[6] = "Pura";
            palavras[7] = "Riso";
            palavras[8] = "Amor";
            palavras[9] = "Vida";

            //palavra escolhida.
            Random palavraSorteada = new Random();
            palavraEscolhid = palavraSorteada.Next(10);

            foreach (Control letras in this.Controls) 
            {
                switch (palavraEscolhid) //De acordo com o valor da variável palavraEscolhid a palavra será Escolhida.
                {
                        //Caso o valor dela seja algum desses mudar as letras.
                    case 0:
                        letra1.Text = palavras[0].Replace("Sina", "S").ToUpper();
                        letra2.Text = palavras[0].Replace("Sina", "*").ToUpper();
                        letra3.Text = palavras[0].Replace("Sina", "*").ToUpper();
                        letra4.Text = palavras[0].Replace("Sina", "A").ToUpper();
                        break;

                    case 1:
                        letra1.Text = palavras[1].Replace("Casa", "*").ToUpper();
                        letra2.Text = palavras[1].Replace("Casa", "A").ToUpper();
                        letra3.Text = palavras[1].Replace("Casa", "*").ToUpper();
                        letra4.Text = palavras[1].Replace("Casa", "A").ToUpper();
                        break;

                    case 2:
                         letra1.Text = palavras[2].Replace("Fogo", "*").ToUpper();
                        letra2.Text = palavras[2].Replace("Fogo", "*").ToUpper();
                        letra3.Text = palavras[2].Replace("Fogo", "G").ToUpper();
                        letra4.Text = palavras[2].Replace("Fogo", "O").ToUpper();
                        break;

                    case 3:
                        letra1.Text = palavras[3].Replace("Loja", "L").ToUpper();
                        letra2.Text = palavras[3].Replace("Loja", "*").ToUpper();
                        letra3.Text = palavras[3].Replace("Loja", "*").ToUpper();
                        letra4.Text = palavras[3].Replace("Loja", "A").ToUpper();
                        break;

                    case 4:
                         letra1.Text = palavras[4].Replace("Urso", "U").ToUpper();
                        letra2.Text = palavras[4].Replace("Urso", "*").ToUpper();
                        letra3.Text = palavras[4].Replace("Urso", "s").ToUpper();
                        letra4.Text = palavras[4].Replace("Urso", "*").ToUpper();
                        break;

                    case 5:
                        letra1.Text = palavras[5].Replace("Seda", "S").ToUpper();
                        letra2.Text = palavras[5].Replace("Seda", "*").ToUpper();
                        letra3.Text = palavras[5].Replace("Seda", "*").ToUpper();
                        letra4.Text = palavras[5].Replace("Seda", "*").ToUpper();
                        break;

                    case 6:
                        letra1.Text = palavras[6].Replace("Pura", "P").ToUpper();
                        letra2.Text = palavras[6].Replace("Pura", "*").ToUpper();
                        letra3.Text = palavras[6].Replace("Pura", "R").ToUpper();
                        letra4.Text = palavras[6].Replace("Pura", "*").ToUpper();
                        break;

                    case 7:
                        letra1.Text = palavras[7].Replace("Riso", "*").ToUpper();
                        letra2.Text = palavras[7].Replace("Riso", "I").ToUpper();
                        letra3.Text = palavras[7].Replace("Riso", "S").ToUpper();
                        letra4.Text = palavras[7].Replace("Riso", "*").ToUpper();
                        break;

                    case 8:
                        letra1.Text = palavras[8].Replace("Amor", "A").ToUpper();
                        letra2.Text = palavras[8].Replace("Amor", "*").ToUpper();
                        letra3.Text = palavras[8].Replace("Amor", "*").ToUpper();
                        letra4.Text = palavras[8].Replace("Amor", "R").ToUpper();
                        break;

                    case 9:
                        letra1.Text = palavras[9].Replace("Vida", "*").ToUpper();
                        letra2.Text = palavras[9].Replace("Vida", "I").ToUpper();
                        letra3.Text = palavras[9].Replace("Vida", "*").ToUpper();
                        letra4.Text = palavras[9].Replace("Vida", "A").ToUpper();
                        break;

                    default:
                        Application.Restart(); //Reinicia a aplicação caso o valor de Palavraescolhid não seja nenhum desses.
                        break;
                }
            }
        } //Escolhe uma palavra aleatória do arrays de palavras.

        private void VerificarSeCorreta() 
        {
            switch (palavraEscolhid) //Verifica o valor da variável escolhida e com base nele verifica o que o usuário digitou.
            {
                case 0:
                    //Se o texto digitado for igual a Sina, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                    if (txtPalavra.Text.ToUpper()== "sina" || txtPalavra.Text.ToLower() == "sina")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else 
                    {
                        erro++;
                        ContErros.Text = "Erros: " + erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca.
                    }
                    break;

                case 1:
                    //Se o texto digitado for igual a Casa, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                    if (txtPalavra.Text.ToUpper() == "casa" || txtPalavra.Text.ToLower() == "casa")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else 
                    {
                        erro++; //Acrescenta +1 para a variável erro.
                        ContErros.Text = "Erros: " + erro.ToString(); //Mostra a quantidade de erros na tela.
                        VerificarErros(); ; //Executa o método que muda o desenho da forca.
                    }
                    break;

                case 2:
                    //Se o texto digitado for igual a Fogo, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                    if (txtPalavra.Text.ToUpper() == "fogo" || txtPalavra.Text.ToLower() == "fogo")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else 
                    {
                        erro++;
                        ContErros.Text = "Erros: " + erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca.
                    }
                    break;

                case 3:
                    //Se o texto digitado for igual a Loja, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                    if (txtPalavra.Text.ToUpper() == "loja" || txtPalavra.Text.ToLower() == "loja")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else 
                    {
                        erro++;
                        ContErros.Text = "Erros: " + erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca.
                    }
                    break;
                //Se o texto digitado for igual a Urso, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                case 4:
                    if (txtPalavra.Text.ToUpper() == "urso" || txtPalavra.Text.ToLower() == "urso")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else
                    {
                        erro++;
                        ContErros.Text = "Erros: " + erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca.
                    }
                    break;

                case 5:
                //Se o texto digitado for igual a Seda, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                    if (txtPalavra.Text.ToUpper() == "seda" || txtPalavra.Text.ToLower() == "seda")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else
                    {
                        erro++;
                        ContErros.Text = "Erros: " + erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca. 
                    }
                    break;

                case 6:
                    //Se o texto digitado for igual a Pura, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                    if (txtPalavra.Text.ToUpper() == "pura" || txtPalavra.Text.ToLower() == "pura")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else
                    {
                        erro++;
                        ContErros.Text = "Erros: " + erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca.
                    }
                    break;

                case 7:
                    //Se o texto digitado for igual a Riso, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                    if (txtPalavra.Text.ToUpper() == "riso" || txtPalavra.Text.ToLower() == "riso")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else
                    {
                        erro++;
                        ContErros.Text = "Erros: "+erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca.  
                    }
                    break;

                //Se o texto digitado for igual a Amor, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                case 8:
                    if (txtPalavra.Text.ToUpper() == "amor" || txtPalavra.Text.ToLower() == "amor")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else 
                    {
                        erro++;
                        ContErros.Text = "Erros: " + erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca.
                    }
                    break;

                //Se o texto digitado for igual a Amor, não importando se está em maiuscula ou minuscula, mostre a mensagem.
                case 9:
                    if (txtPalavra.Text.ToUpper() == "vida" || txtPalavra.Text.ToLower() == "vida")
                    {
                        MessageBox.Show("Você venceu!", "Vitória", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vitorias++;
                        lblVitorias.Text = "Vitórias:" + vitorias; //Acrescenta +1 para a variável e mostra a quantidade na label.
                        ReiniciarJogo();
                    }
                    else
                    {
                        erro++;
                        ContErros.Text = "Erros: " + erro.ToString();
                        VerificarErros(); //Executa o método que muda o desenho da forca.
                    }
                    break;
            }
        } //Verifica se a palavra digitada é correta.

        private void VerificarErros() //Faz com que o desenho mude na tela e mostra a mensagem quando o usuário perder.
        {
            switch (erro) //Verifica o valor da variável erro e com base em seu valor muda o desenho para o usuário.
            {
                case 1:
                    forca.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Documents\Visual Studio 2010\Projects\JogodaForca\JogodaForca\Imgs\forca_cabeca.png");
                    forca.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 2:
                    forca.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Documents\Visual Studio 2010\Projects\JogodaForca\JogodaForca\Imgs\forca_corpo.png");
                    forca.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 3:
                    forca.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Documents\Visual Studio 2010\Projects\JogodaForca\JogodaForca\Imgs\forca_braco_direito.png");
                    forca.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 4:
                    forca.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Documents\Visual Studio 2010\Projects\JogodaForca\JogodaForca\Imgs\forca_braco_esquerdo.png");
                    forca.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case 5:
                    forca.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Documents\Visual Studio 2010\Projects\JogodaForca\JogodaForca\Imgs\forca_perna_esquerda.png");
                    forca.BackgroundImageLayout = ImageLayout.Stretch;
                    break;

                case 6:
                    forca.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Documents\Visual Studio 2010\Projects\JogodaForca\JogodaForca\Imgs\forca_perna_direita.png");
                    forca.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
            }

            if (erro == 6) //Se o valor de erro for 6, faça o que está abaixo.
            {
                //Mostra a mensagem.
                MessageBox.Show("Você perdeu :(", "Perdeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPalavra.Text = string.Empty; //Limpa a caixa de texto.
                erro = 0; //Reseta a quantidade de erros.
                ContErros.Text = "Erros: "; //Reseta a label que mostra os erros.
                //Muda a imagem da forca para a forca vazia.
                forca.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Documents\Visual Studio 2010\Projects\JogodaForca\JogodaForca\Imgs\forca.png");
                ReiniciarJogo(); //Reinicia o jogo.
            }
        }

        private void ReiniciarJogo() //Método que reinicia o jogo 
        {
            //Muda a imagem da forca para ela vazia.
            txtPalavra.Text = string.Empty; //Limpa a caixa de texto.
            forca.BackgroundImage = Image.FromFile(@"C:\Users\Usuario\Documents\Visual Studio 2010\Projects\JogodaForca\JogodaForca\Imgs\forca.png");
            GerarPalavra(); //Executa o método que faz a palavra ser escolhida aleatóriamente.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarJogo(); //Executa o método sempre que o programa é inicializado.
        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {
            if (txtPalavra.Text.Count() == 4) //Se a conta do texto escrito for 4 ou seja, se tiver 4 caracteres, executar o que está dentro do if.
            {
                VerificarSeCorreta(); //Sempre que o texto for modificado executar o método.
            }
        }//Evento que ocorre toda vez que texto da txtbox é modificado.

        
    }
}
