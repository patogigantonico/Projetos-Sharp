using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicativo_Juros_simples_e_compostos
{
    class JurosSimples
    {
        public double capital, taxa, tempo; //Variáveis que recebem os valores definidos pelo usuário.

        //Sessão de métodos//
        public double CalcJurosSimples() 
        {
            return capital * taxa * tempo; //Multiplica o capital a taxa e o tempo.
        }
        public double ResultJuros() 
        {
            return CalcJurosSimples(); //Retorna o valor total da multiplicação do método acima.
        }
        //Fim da sessão de métodos.
    }
}
