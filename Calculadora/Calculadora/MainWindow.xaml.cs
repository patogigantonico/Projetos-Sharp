using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string operacao;
        List<double> numeros = new List<double>();
        double resultado;       
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Esvazia a string assim que o programa é aberto.
            lblOperacao.Content = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "1";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "2";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "3";
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "4";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "5";
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "6";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "7";
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "8";
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "9";
        }

        private void button0_Click(object sender, RoutedEventArgs e)
        {
            txtOperacao.Text += "0";
        }

        private void botaoApagar_Click(object sender, RoutedEventArgs e)
        {
            //Se houver algo selecionado.
            if (txtOperacao.SelectedText.Length > 0)
            {
                //Remove todos o caracteres selecionados pelo usuário.
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.SelectionStart, txtOperacao.SelectionLength);
            }
            else if (txtOperacao.Text == string.Empty) 
            {
                MessageBox.Show("Não há nada inserido!","Info", MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else //Se não.
            {
                //Remove apenas um caractere da txtbox caso nada tenha sido selecionado.
                txtOperacao.Text = txtOperacao.Text.Remove(txtOperacao.Text.Length - 1);
            }

        }

        private void botaoSoma_Click(object sender, RoutedEventArgs e)
        {
            if (txtOperacao.Text == string.Empty)
            { MessageBox.Show("Insira um valor inicial!","Info", MessageBoxButton.OK, MessageBoxImage.Information); }
            else
            {
                operacao = "+";
                if (operacao == "+") //Se a operação for
                {
                    numeros.Add(double.Parse(txtOperacao.Text));
                    lblOperacao.Content = "+";
                    txtOperacao.Text = string.Empty;
                }
            }
        }

        private void botaoMenos_Click(object sender, RoutedEventArgs e)
        {
            //Esse código verifica se a txtbox está vazia e caso não executa a subtração.

            if (txtOperacao.Text == string.Empty)
            { MessageBox.Show("Insira um valor inicial!", "Info", MessageBoxButton.OK, MessageBoxImage.Information); }
            else
            {
                operacao = "-";
                if (operacao == "-")
                {
                    numeros.Add(double.Parse(txtOperacao.Text)); //Converte o valor para double.
                    lblOperacao.Content = "-"; //muda a lbl para "-"
                    txtOperacao.Text = string.Empty; //Esvazia a caixa para que se possa inserir outro valor.
                }
            }
        }

        private void botaoIgual_Click(object sender, RoutedEventArgs e)
        {
            numeros.Add(double.Parse(txtOperacao.Text)); //Converte o valor para double e executa o que está abaixo

            if (numeros.Count < 2) //Se não houver pelo menos 2 números para ser realizado a operação.
            {
                MessageBox.Show("Insira os valores corretamente!","Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else //Se não.
            {
                switch (operacao) //Verifica o valor da variável operação.
                {
                        //Caso o valor da variável operação seja "+" ou "-" executar as suas respectivas ações.

                    case "+":
                        lblOperacao.Content = operacao; //Muda o lbl que indica qual operação está sendo feita.
                        txtOperacao.Text = Convert.ToString(numeros.Sum()); //Converte para string e soma todos os valores da lista.
                        lblOperacao.Content = ""; //Remove o sinal da operação ao mostrar o resultado na txtbox.
                        numeros.Clear(); //Limpa a lista que armazena os números inseridos.
                        break;

                    case "-":
                        lblOperacao.Content = operacao; //Muda o lbl que indica qual operação está sendo feita.
                        resultado = numeros[0]; //A variável resultado recebe o valor do primeiro número inserido na lista.
                        //A lista ignora o primeiro valor dela(numeros[0]) e converte para lista, logo após a função (valor =>) subtrai a variável resultado e valor.
                        numeros.Skip(1).ToList().ForEach(valor => resultado -= valor);      
                        txtOperacao.Text = resultado.ToString(); //O txt recebe o valor do resultado que é convertido para string.                         
                        lblOperacao.Content = ""; //Remove o sinal da operação ao mostrar o resultado na txtbox.
                        numeros.Clear(); //Por fim a lista é limpa para que se possa realizar outro cálculo.
                        break; 
                }

                
            }
            
        }        
    }
}
