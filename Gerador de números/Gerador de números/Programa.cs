using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gerador_de_números
{
    public partial class Programa : Form
    {
        //Declaração das variáveis.
        int[] numero_min_max = new int[2];
        int contador = 0;

        public Programa()
        {
            InitializeComponent();
        }

        private void Programa_Load(object sender, EventArgs e)
        {
            //Assim que o programa é iniciado a variável recebe a imagem do dado parado.
            dado.BackgroundImage = Image.FromFile(@"C:\Program Files (x86)\Patogigantonico\Gerador de números\imagens\game-die_1f3b2.png");
            dado.BackgroundImageLayout = ImageLayout.Zoom; //Ajusta a imagem.
        }

        private void dado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NumMinimo.Text) || string.IsNullOrEmpty(NumMax.Text)) //Caso nenhum campo tenha sido preenchido ou falte preencher um.
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numero_min_max[0] > numero_min_max[1]) //Caso o número mínimo seja maior que o máximo.
            {
                MessageBox.Show("O valor mínimo não pode ser maior que o máximo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Limpa as caixas de texto.
                NumMinimo.Text = string.Empty;
                NumMax.Text = string.Empty;
            }
                //Caso a conversão para inteiro falhe.
            else if(!int.TryParse(NumMinimo.Text, out numero_min_max[0]) || !int.TryParse(NumMax.Text, out numero_min_max[1]))
            {
                MessageBox.Show("Não foi possível converter os valores, digite apenas números inteiros!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Limpa as caixas de texto.
                NumMinimo.Text = string.Empty;
                NumMax.Text = string.Empty;
            }
            else //Caso tudo tenha dado certo.
            {
                //Reseta a label (Caso o usuário clique no dado novamente).
                lblNumGerado.Text = "Número gerado: ";

                //O Valor digitado das caixas é convertido para inteiro e atribuido ao array.
                numero_min_max[0] = int.Parse(NumMinimo.Text);
                numero_min_max[1] = int.Parse(NumMax.Text);

                //O timer é habilitado e o seu intervalo é definido para 60 milésimos.
                timer1.Enabled = true;
                timer1.Interval = 60;

                //Muda a imagem para o dado girando, e remove a imagem do dado parado.
                dado.Image = Image.FromFile(@"C:\Program Files (x86)\Patogigantonico\Gerador de números\imagens\Gifs animados Dado 8.gif");
                dado.BackgroundImageLayout = ImageLayout.Zoom;
                dado.BackgroundImage = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random numeroGerado = new Random(); //Instância da classe random no objeto numeroGerado.
            contador++; //A variável contador recebe +1 a cada 60 milésimos.

            if (contador == 35) //Se o contador chegar ao valor 35.
            {
                timer1.Enabled = false; //O timer é desativado.
                contador = 0; //A variável contador é resetada.

                //A imagem do dado muda para ele parado e remove a imagem do dado girando.
                dado.BackgroundImage = Image.FromFile(@"C:\Program Files (x86)\Patogigantonico\Gerador de números\imagens\game-die_1f3b2.png");
                dado.Image = null;

                //Mostra o número gerado com base nos valores minimo e máximo.
                lblNumGerado.Text = "Número gerado: " + numeroGerado.Next(numero_min_max[0], numero_min_max[1]); 
            }
        }
    }
}
