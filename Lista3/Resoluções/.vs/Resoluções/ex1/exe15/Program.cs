// O proprietário de um hotel criou uma forma original de cobrar seus clientes. A primeira noite custa R$ 
//50,00.A segunda custa R$ 25,00 (ou seja, R$ 50,00 / 2), a terceira R$ 50,00 / 3 e a n-ésima noite custa 
//R$ 50,00 / n. Elabore um programa que calcule a cobrança a efetuar a um cliente que fique "X" noites no 
//hotel. O programa deve indicar o preço a pagar por cada noite e o total a pagar

Console.WriteLine("Quantas noites o cliente ficará no hotel?");
int n = Convert .ToInt32(Console.ReadLine());

double custo = 0, soma = 0;

for (int i = 1; i <= n; i++)
{
    custo = 50 / i;
    Console.WriteLine($"Valor a ser pago na {i}° noite: {custo}");
    soma += custo;
}
Console.WriteLine();
Console.WriteLine("Valor total a ser pago: " + soma);