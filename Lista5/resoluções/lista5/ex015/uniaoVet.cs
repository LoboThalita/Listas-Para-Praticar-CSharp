using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex015
{
    public class uniaoVet
    {

        public void unir(int[] v1, int[] v2)
        {
            int[] uniao = new int[v1.Length + v2.Length];

            for (int i = 0;  i < v1.Length; i++)
            {
                uniao[i] = v1[i];
            }

            int j = v1.Length;
            int quant;

            for (int i = 0; i < v2.Length;i++)
            {
                quant = 0;
                for(int k =  0; k < v1.Length + 1;k++)
                {
                    if (uniao[i] == v2[k])
                        quant++;
                }
                if (quant == 0)
                {
                    uniao[j++] = v2[i];
                }
            }

            Console.WriteLine("União:");

            for (int i = 0; i < uniao.Length; i++)
            {
                if (uniao[i] != 0)
                    Console.WriteLine(uniao[i] + " ");
            }
        }
    }
}
