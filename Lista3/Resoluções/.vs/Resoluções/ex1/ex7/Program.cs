// Elabore um programa que leia uma sequência de números inteiros a partir do teclado e apresente o
//máximo e o mínimo. O programa termina quando o número lido for zero.

int num = 1, max = 0, min = 999999999;
var numeros = new List<int>();

while (num != 0)
{
    Console.WriteLine("Informe um número. (Caso queira parar, digite zero");
    num = Convert.ToInt32(Console.ReadLine());

    if (num !=0)
        numeros.Add(num);
}

foreach(int n in numeros)
{
    if (n > max) max = n;
    if(n < min) min = n;
}

Console.WriteLine("Maior número: " + max);
Console.WriteLine("Menor número: " + min);