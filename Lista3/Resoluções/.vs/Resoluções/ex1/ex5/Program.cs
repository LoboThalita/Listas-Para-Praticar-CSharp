// Modifique o programa anterior para apresentar no final a soma dos números.

Console.WriteLine("Informe um número");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe outro número");
int num2 = Convert.ToInt32(Console.ReadLine());

int soma = 0;

if (num1 < num2)
{
    Console.WriteLine($"Números entre {num1} e {num2}:");
    for (int i = num1 + 1; i < num2; i++)
    {
        Console.Write(i + ", ");
        soma += i;
    }
    Console.WriteLine();
    Console.WriteLine("Soma dos números = " + soma);
}

if (num2 < num1)
{
    Console.WriteLine($"Números entre {num2} e {num1}:");
    for (int i = num2 + 1; i < num1; i++)
    {
        Console.Write(i + ", ");
        soma += i;
    }
    Console.WriteLine();
    Console.WriteLine("Soma dos números = " + soma);
}

if (num1 == num2)
{
    Console.WriteLine("Os números são iguais");
    Console.WriteLine("Soma dos números = 0 ");
}


    
