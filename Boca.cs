using System;
using System.Collections.Generic;
using System.Text;

namespace Ativideda_27_02
{
    public class Boca
    {
        public void Solucao1(int n) 
        {
            if (n % 3 == 0)
            {
                Console.WriteLine(0);
            }
            else if (n % 3 == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }
    }

}
