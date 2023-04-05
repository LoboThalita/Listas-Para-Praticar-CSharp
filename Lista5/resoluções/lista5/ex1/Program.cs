int[] vet = new int[100];
int soma = 0;
Console.WriteLine("Informe o valor de n");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 100)
    Console.WriteLine("Número inválido");
else
{
    for(int i = 0; i < n; i++)
    {
        Console.WriteLine($"Informe o valor da {i+1} posição");
        vet[i] = Convert.ToInt32(Console.ReadLine());
        soma += vet[i];
    }

    Console.WriteLine($"Soma dos números: {soma}");
}




