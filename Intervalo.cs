using System;
using System.Collections.Generic;
using System.Text;

namespace Ativideda_27_02
{
    public class Intervalo
    {
        public void Solucao3(float nn)
        {
            if (nn >= 0 && nn <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            if (nn >= 25 && nn <= 50)
            {
                Console.WriteLine("Intervalo [25, 50]");
            }
            if (nn >= 50 && nn <= 75)
            {
                Console.WriteLine("Intervalo [50, 75]");
            }
            if (nn >= 75 && nn <= 100)
            {
                Console.WriteLine("Intervalo [75, 100]");
            }
        }
    }
}
