// Elabore um programa que receba dois números inteiros e gere os números inteiros que estão no intervalo
//compreendido por eles.

Console.WriteLine("Informe um número");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe outro número");
int num2 = Convert.ToInt32(Console.ReadLine());



if (num1 < num2)
{
    Console.WriteLine($"Números entre {num1} e {num2}:");
    for (int i = num1+1; i < num2; i++)
    {
        Console.Write(i + ", ");
    }
}
if (num2 < num1)
{
    Console.WriteLine($"Números entre {num2} e {num1}:");
    for (int i = num2 + 1; i < num1; i++)
    {
        Console.Write(i + ", ");
    }
}
if (num1 == num2)
    Console.WriteLine("Os números são iguais");

if (num1+1 == num2 || num2+1 == num1)
    Console.WriteLine("Nulo");