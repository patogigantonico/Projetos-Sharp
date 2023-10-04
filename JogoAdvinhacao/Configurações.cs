using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoAdvinhacao
{
    class Configurações //Classe com os métodos que fazem o jogo funcionar.
    {
        //Declaração das variáveis.
        int inicial = 0, final = 0,pontos = 0, numero_gerado = 0; 
        string resp;
        bool desistiu = false;

        public void Iniciar_E_VerificarResp() //Este método mostra a mensagem inicial na tela e aguarda o usuário iniciar o jogo.
        {
            Console.WriteLine("Bem-vindo(a) ao jogo de advinhação! \nComo funciona?\n \nO computador irá gerar um número aleatório e você deve advinhar qual é, quanto mais você acerta mais aumentará seus pontos. Para iniciar digite INICIAR");
            resp = Console.ReadLine();

            //Enquanto a resposta não for sair ou iniciar.
            while (resp.Equals("INICIAR", StringComparison.OrdinalIgnoreCase) == false)
            {
                Console.WriteLine("Comando inválido, tente novamente!");
                resp = Console.ReadLine();
            }

            while (resp.Equals("SAIR", StringComparison.OrdinalIgnoreCase) == true)
            {
                Environment.Exit(0);
            }
        }

        public void Inserir_Valor() //Este método solicita que o usuário insira um valor inicial e final para que seja gerado um número.
        {
            Console.Clear();
            Console.WriteLine("Digite o valor inicial a ser gerado pelo computador:");
            inicial = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite o valor final a ser gerado pelo computador:");
            final = Convert.ToInt16(Console.ReadLine());
        }

        public void Verificar_Valores() //Este método verifica se o valor inicial não é menor que o final.
        {
            while (final < inicial) //Se o valor final for menor que o inicial.
            {
                Console.Clear();
                Console.WriteLine("O valor inicial não pode ser maior que o final!");
                Console.WriteLine("Digite novamente o valor inicial:");
                inicial = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite novamente o valor final:");
                final = Convert.ToInt16(Console.ReadLine());
            }
        }

        public void Gerar_Numero() //Este método gera o valor e o armazena na variável.
        {
            Random numero = new Random(); 
            numero_gerado = numero.Next(inicial,final);
        }

        public void InciarJogo() //Este método inicia o jogo.
        {
            while (true) 
            {
                Console.WriteLine("O número foi gerado tente advinhar qual seria ele:");
                Console.WriteLine("Sua pontuação atual é de: "+pontos);
                resp = Console.ReadLine();

                if (int.Parse(resp) != numero_gerado) //Se a resposta não for igual ao número gerado.
                {
                    //Aqui o jogador errou.
                    Console.WriteLine("Você errou, o número era: " + numero_gerado);
                    Console.WriteLine("Deseja jogar novamente ou irá sair? \n Digite CONTINUAR ou SAIR");
                    resp = Console.ReadLine();

                    if (resp.Equals("CONTINUAR", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        Reiniciar();
                    }
                    if (resp.Equals("SAIR", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        desistiu = true;
                    }
                }
                else //Aqui o jogador acertou o número.
                {
                    Console.WriteLine("Você acertou!");
                    Console.WriteLine("Sua pontuação agora é: " + pontos++);
                    Console.WriteLine("Deseja jogar novamente ou irá sair? \n Digite CONTINUAR ou SAIR");
                    resp = Console.ReadLine();
                    //Se a resposta for continuar não importando se está maiuscula ou minuscula
                    if (resp.Equals("CONTINUAR", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        Reiniciar(); 
                    }
                    //Se a resposta for sair não importando se está maiuscula ou minuscula
                    if (resp.Equals("SAIR", StringComparison.OrdinalIgnoreCase) == true)
                    {
                        desistiu = true; //A variável é verdadeira
                    }  
                }

                if (desistiu == true) //Se desistiu for verdade
                {
                    Environment.Exit(0); //Encerra o aplicativo.
                }
            }
        } 

        protected void Reiniciar()  //Este método executa novamente o método iniciarJogo,limpa o console e gera um novo número.
        {
            Gerar_Numero(); //Gera um novo valor com base nos que já foram inseridos.
            Console.Clear(); //Limpa a tela.
            InciarJogo(); //Executa novamente toda a rotina do método.
        }
    }
}
