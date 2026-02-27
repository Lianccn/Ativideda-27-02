using System;
using System.Collections.Generic;
using System.Text;

namespace Ativideda_27_02
{
    public class GastoCombustivel
    {
        public double litros;
        public void Solucao2(double tempo, double velocidade)
        {
            litros = (tempo * velocidade) / 12.0;  
        }
    }
}
