using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Juros_simples_e_compostos.Classes
{
    class JurosCompostos
    {
        public double montante, capital, taxa, tempo; //Variáveis que recebem os valores digitados pelo user.

        //Sessão de métodos//
        public double CalcularJurosComp() 
        {
            return montante = capital * Math.Pow(1 + taxa, tempo); //Calcula o  juros compostos.
        }

       public double Result() 
        {
            return CalcularJurosComp(); //Retorna o resultado da operação do método acima.
        }
        //Fim da sessão de métodos.
    }
}
