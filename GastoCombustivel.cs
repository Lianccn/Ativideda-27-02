using System;
using System.Collections.Generic;
using System.Text;

namespace Ativideda_27_02
{
    public class GastoCombustivel
    {
        public double litros;
        public double Solucao2(double tempo, double velocidade)
        {
            litros = (tempo * velocidade) / 12.0;
            Console.WriteLine($"{litros:F3}");
            //Console.WriteLine("{0:F3}", litros); --> mesma coisa que a linha de cima, só que usando o formato de string do C# 6.0
            return litros;
        }
    }
}
