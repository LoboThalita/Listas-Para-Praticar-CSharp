using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex014
{
    public class intersecaoVets
    {

        public void interseccao(int[] v1, int[] v2)
        {
            int maior, menor;

            if (v1.Length >= v2.Length) {
                maior = v1.Length;
                menor = v2.Length;
            }
            else {
                maior = v2.Length;
                menor = v1.Length; }


            int[] inter = new int[maior];

            int k = 0;

            for (int i = 0; i <maior; i++)
            {
                for (int j = 0; j < menor; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        inter[k++] = v2[j];
                        break;
                    }
                }
            }
            Console.WriteLine("Intersecção:");
            for(int i = 0; i < inter.Length; i++)
            {
                if (inter[i] != 0)
                    Console.Write(inter[i] + " ");
            }
        }

    }
}
