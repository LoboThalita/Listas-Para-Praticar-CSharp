using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex006
{
    public class indiceMaior
    {

        public void Maior(int[] v)
        {
            int maior = 0, quant = 0;
            

            for(int i = 0; i < v.Length; i++)
            {
                if (v[i] > maior) maior = v[i];
            }

            for(int i = 0; i < v.Length; i++)
            {
                if (v[i] == maior)
                {
                    quant++;
                }
            }
            int[] indicesMaior = new int[quant];
            int j = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == maior)
                {
                    indicesMaior[j] = i;
                    j++;
                }
            }

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine(indicesMaior[i]);
            }
        }
    }
}
