// Um número perfeito é um número inteiro positivo para o qual a soma de todos os seus divisores inteiros
// positivos próprios(excluindo ele mesmo) é igual ao próprio número. Elabore um programa que apresente
// na tela todos os números perfeitos até 10000.

Console.WriteLine("Números perfeitos até 10000:");
for (int i = 1; i <= 10000; i++)
{
    int soma = 0;
    for (int j = 1; j <= i/2; j++)
    {
        if (i % j == 0) soma += j;
    }

    if (soma == i) Console.WriteLine(i);
}