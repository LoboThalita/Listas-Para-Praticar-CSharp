using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex031
{
    public class BuscaBRecursiva
    {

        public int BuscaRecursiva(int[] vet, int valor, int esquerda, int direita)
        {
            if (direita < esquerda)
                return -1;

            int meio = (esquerda + direita) / 2;

            if (vet[meio] == valor) return meio;
            else if (vet[meio] > valor)
                return BuscaRecursiva(vet, valor, esquerda, meio - 1);
            else
                return BuscaRecursiva(vet, valor, meio + 1, direita);
        }

    }
}
