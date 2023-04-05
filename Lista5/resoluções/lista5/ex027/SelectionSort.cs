using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex027
{
    public class SelectionSort
    {

        public void ordena(int[] v)
        {
            int min, aux;
            for (int i = 0; i < v.Length - 1; i++)
            {
                min = i;
                for (int j = (i + 1); j < v.Length; j++)
                {
                    if (v[j] < v[min]) min = j;
                }
                if (v[i] != v[min])
                {
                    aux = v[i];
                    v[i] = v[min];
                    v[min] = aux;
                }
            }
        }
    }
}
