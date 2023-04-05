using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex026
{
    public class program
    {

        public void InsertionSort(int[]vet)
        {
            for(int i = 0; i < vet.Length-1; i++)
            {
                for(int j = i + 1; j > 0; j--) {
                    if (vet[j-1] > vet[j])
                    {
                        int aux = vet[j -1];
                        vet[j - 1] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
        }
    }
}
