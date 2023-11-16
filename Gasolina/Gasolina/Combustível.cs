using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gasolina
{
    class Combustível
    {
        public string NomeVeiculo,tipo;
        public double KmLitro, ValorLitro, Dinheiro, QtdeLitros, QtdeKM;

        public double CalcLitros() 
        {
            return Dinheiro / ValorLitro;
        }

        public double CalcKM() 
        {
            return KmLitro * QtdeLitros;
        }

        public double MostrarResult() 
        {
            return QtdeKM = CalcKM();
        }
    }
}
