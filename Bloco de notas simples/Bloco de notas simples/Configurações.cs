using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Bloco_de_notas_simples
{
    class Configurações
    {
        //Variáveis para editar as fontes.
        static public string Fonte;
        static public object Cor;
        static public int Tamanho = 0;
        static public bool atualizou = false;

        static public void VerificarCor(object cor) 
        {
            //Verifica se a cor é conhecida.
            KnownColor corconhecida = new KnownColor();
            if (Enum.TryParse((string)cor, out corconhecida)) 
            {
                //Transforma a string em cor.
                Color NovaCor = Color.FromKnownColor(corconhecida);
                Cor = NovaCor; //Atribui a cor para a variável.
            }
        }

        public void AbrirArquivoTexto(TextBox arquivo) //Este método exibe uma janela de diálogo para abrir arquivos.
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de texto *.txt | *.txt*"; 
            ofd.ShowDialog(); //Abre a janela ao clicar no botão (sempre lembrar de colocar o nome da variável antes).

            if (string.IsNullOrEmpty(ofd.FileName) == false) //Se o nome houver nome no arquivo.
            {
                try
                {
                    StreamReader str = new StreamReader(ofd.FileName, Encoding.Default);
                    arquivo.Text = str.ReadToEnd(); //Lê os caracteres do arquivo e repassa para txtbox
                }
                catch (Exception ex) //Retorna a mensagem de erro caso não consiga abrir o arquivo. 
                {
                   MessageBox.Show(ex.Message, "Não foi possível abrir o arquivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void SalvarArquivo(string arquivo) //Este método exibe uma janela de diálogo para salvar arquivos.
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Arquivos de texto *.txt | *.txt";
            salvar.ShowDialog(); //Abre a janela ao clicar no botão (sempre lembrar de colocar o nome da variável antes).
            if (string.IsNullOrEmpty(salvar.FileName) == false)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(salvar.FileName); //Salva o arquivo com o nome digitado pelo user.
                    writer.WriteLine(arquivo); //Salva o texto escrito pelo usuário.
                    MessageBox.Show("Salvo com sucesso!!"); //Mostra mensagem de salvo para o usuário.
                    writer.Flush();// Deleta da memória ram os dados adquiridos antes.

                }
                catch (Exception ex) //Retorna a mensagem de erro caso não consiga salvar o arquivo. 
                {
                    MessageBox.Show(ex.Message, "Não foi possível salvar o arquivo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
