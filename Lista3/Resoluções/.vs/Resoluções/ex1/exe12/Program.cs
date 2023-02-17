//Elabore um programa que determine os divisores de um número inteiro introduzido pelo utilizado

Console.WriteLine("Informe um número inteiro");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Divisores de: " + n);

for (int i = 1; i <= n; i++)
{
    if (n % i == 0) Console.Write(i + " ");
}
