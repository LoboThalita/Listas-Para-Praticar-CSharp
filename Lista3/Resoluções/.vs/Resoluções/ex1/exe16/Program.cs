// Elabore um programa que apresente todos os primos entre 1 e N sendo N um número inteiro fornecido
// pelo usuário.O programa deverá apresentar também o número de divisões que ele executou para
// encontrar os números primos.

Console.WriteLine("Informe o valor de N");
int n = Convert .ToInt32(Console.ReadLine());

int quant = 0 , div = 0;

Console.WriteLine("Primos de 2 a " + n);
for (int i = 2;i <= n; i++)
{
    quant = 0;
   for (int j = 2; j <= i; j++)
    {
        if (i % j == 0) quant++;
        div += quant;
    }
    if (quant == 1) Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine("Quantidade de divisões realizadas: " + div );