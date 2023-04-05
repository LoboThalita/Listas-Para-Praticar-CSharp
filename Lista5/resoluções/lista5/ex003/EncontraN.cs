using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex003
{
    public class EncontraN
    {
        public int encN(int[] v)
        {
            Console.WriteLine("Informe o valor que deseja encontrar");
            int n = Convert.ToInt32(Console.ReadLine());

            int quant = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (n == v[i])
                    quant++;
            }

            if (quant == 0)
                return -1;
            else
                return quant;
        }
    }
}
