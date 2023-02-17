// Elabore um programa que determine se um determinado número inteiro é positivo e par

Console.WriteLine("informe um número inteiro");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 0)
{
    if (x % 2 == 0)
        Console.WriteLine("O número inteiro é positivo e par");
    else
        Console.WriteLine("O número inteiro é positivo, mas não é par");
}
else
{
    if (x % 2 == 0)
        Console.WriteLine("O número inteiro não é positivo e é par");
    else
        Console.WriteLine("O número inteiro não é positivo e não é par");
}