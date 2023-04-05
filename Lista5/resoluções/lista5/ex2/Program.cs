Console.WriteLine("Informe o valor de n");
int n = Convert.ToInt32(Console.ReadLine());
int[]v = new int[n];

if (n <= 100)
{
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine("Informe o valor de posição " + i+1);
        v[i] = Convert.ToInt32(Console.ReadLine());
    }
    int media = Calculamedia(v, n);
    Console.WriteLine("Média dos valores informados: " + media);
}else
    Console.WriteLine("Valor de n inválido");

int Calculamedia(int[]v, int n)
{
    int media, soma = 0;

    for (int i = 0; i < n; i++)
        soma += v[i];

    media = soma/n;

    return media;
}
