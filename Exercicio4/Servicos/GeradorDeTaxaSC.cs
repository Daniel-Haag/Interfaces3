using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4.Servicos
{
    class GeradorDeTaxaSC : ITaxa
    {
        public double GerarTaxa(double valor)
        {
            return valor + 15;
        }
    }
}
