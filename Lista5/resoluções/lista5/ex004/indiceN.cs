using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex004
{
    public class indiceN
    {
        public int indice(int[] v)
        {
            Console.WriteLine("Informe o número que deseja encontrar");
            int n = Convert.ToInt32(Console.ReadLine());

            int quant = 0;
            int[] indices= new int[v.Length];

            for(int i = 0; i < v.Length; i++)
            {
                if (v[i] == n)
                {
                    indices[quant] = i;
                    quant++;
                }
            }
            if (quant == 0)
                return -1;
            else
                return indices[0];
        }
    }
}
