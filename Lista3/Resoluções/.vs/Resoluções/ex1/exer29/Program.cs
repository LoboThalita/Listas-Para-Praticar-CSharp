// Elabore um programa que converta a numeração Romana em Árabe

using System.Runtime.CompilerServices;

Console.WriteLine("Digite um número romano");
string rom = 
Console.ReadLine();
char[] Rom = rom.ToCharArray();
int[] valores = new int[Rom.Length];
int result=0;

for(int i = 0; i < Rom.Length; i++)
{
    switch (Rom[i])
    {
        case 'I':
            valores[i] = 1;
            break;

        case 'V':
            valores[i] = 5;
            break;

        case 'X':
            valores[i] = 10;
            break;

        case 'L':
            valores[i] = 50;
            break;

        case 'C':
            valores[i] = 100;
            break;

        case 'D':
            valores[i] = 500;
            break;

        case 'M':
            valores[i] = 1000;
            break;
        default:
            Console.WriteLine("Número inválido");
            break;

    }
}

if (valores.Length == 1)
{
    result = valores[0];
}
else 
{
    for (int i = valores.Length - 1; i > 0; i-=2)
    {
        if (valores[i]  <= valores[i - 1]) result += valores[i] + valores[i - 1];
        else result += valores[i] - valores[i - 1];
    }
    if(valores.Length %2 != 0)
        result += valores[0];
}

Console.WriteLine(result);