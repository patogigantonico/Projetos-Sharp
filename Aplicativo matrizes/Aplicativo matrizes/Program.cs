using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do array bidimensional (int[,]) e declaração dos valores {x,x,x}.
            int[,] valores = new int[6,3] //Indica que a matriz é 5x3.
            {
           //1 2 3 - Colunas
            {1,2,3}, //linha 1
            {3,4,5}, //linha 2
            {6,7,8}, //Linha 3
            {9,10,11},  //linha 4
            {12,13,14},  //linha 5
            {15,16,17}   //linha 6
            };

            int soma = 0; //Variável que recebe a soma de todos os elementos do array.

            for (int linha = 0; linha < 6; linha++) //Percorre as linhas
            {
                for (int coluna = 0; coluna < 3; coluna++) //Percorre as colunas.
                {
                   Console.Write("["+ valores[linha,coluna] +"]"); //Escreve os valores do array na tela.
                   soma += valores[linha, coluna]; //Soma e armazena todos os valores do array.

                    if (coluna == 2) //Verifica se a linha é 3 ou se a coluna é 2
                    {
                        Console.Write("\n"); //Pula uma linha.
                    }
                }
            }
            Console.WriteLine("A soma total dos valores é de: " + soma);
            Console.ReadKey(); //Aguarda pressionar uma tecla.
        }
    }
}
