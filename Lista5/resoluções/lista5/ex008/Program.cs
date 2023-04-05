using System.Globalization;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Informe o valor de N");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    int[] v = new int[n];

    v = PreencheVet(n);

    int[] somaVet = new int[n/2];
    int j = n;

    for(int i = 0; i < n/2; i++)
    {
        somaVet[i] = v[i] + v[j-1];
        j--;
    }

    Console.WriteLine("Novo vetor");
    for(int i = 0; i < n/2; i++)
    {
        Console.Write(somaVet[i] + ", ");
    }

}else
    Console.WriteLine("N precisa ser par");


int[] PreencheVet(int n)
{
    int[] v = new int[n];

    for(int i = 0; i < n; i++)
    {
        Console.WriteLine("Informe o valor da posição " + i);
        v[i] = Convert.ToInt32(Console.ReadLine());
    }

    return v;
}
