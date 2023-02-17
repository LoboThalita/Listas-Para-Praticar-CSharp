//Elabore um programa que verifique se um determinado número é um número perfeito.

Console.WriteLine("Informe um número");
int n = Convert .ToInt32(Console.ReadLine());

int soma =0;

for( int i = 1; i <= n/2; i++)
{
    if (n % i == 0) soma += i;
}

if (soma == n) Console.WriteLine($"O número {n} é perfeito");
else Console.WriteLine($"O número {n} não é perfeito");

