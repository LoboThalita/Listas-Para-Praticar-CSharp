using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex030
{
    public class QuickSort
    {

        public void ordena(int[] vet)
        {
            int inicio = 0, fim = vet.Length - 1;

            Quick(vet, inicio, fim);
        }
        public void Quick(int[] vet, int inicio, int fim)
        {

            if(inicio < fim)
            {
                int p = vet[inicio], i = inicio + 1, f = fim;

                while(i <= f)
                {
                    if (vet[i] <= p)
                        i++;
                    else if (p < vet[f])
                        f--;
                    else
                    {
                        int troca = vet[i];
                        vet[i] = vet[f];
                        vet[f] = troca;
                        i++;
                        f--;
                    }
                }
                vet[inicio] = vet[f];
                vet[f] = p;

                Quick(vet, inicio, f - 1);
                Quick(vet, f + 1, fim);
            }

        }
    }
}
