using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009
{
    public class vetIgual
    {

        public bool verifica(int[] vet1, int[] vet2)
        {
            int quant = 0;
            for (int i = 0; i < vet1.Length; i++)
            {
                if (vet1[i] == vet2[i])
                    quant++;

            }
            if (quant == vet1.Length)
                return true;
            else
                return false;
        }
    }
}
