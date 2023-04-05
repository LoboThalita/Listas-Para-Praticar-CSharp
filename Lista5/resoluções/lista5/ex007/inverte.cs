using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex007
{
    public class Inverte
    {
        public void inverte(int[] v)
        {
            int aux = 0, j = v.Length-1;

            for (int i = 0; i < v.Length/2; i++)
            {
                aux = v[i];
                v[i] = v[j];
                v[j] = aux;
                j--;
            }

            Console.WriteLine("Vetor invertido");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + ", ");
            }
        }
    }
}
