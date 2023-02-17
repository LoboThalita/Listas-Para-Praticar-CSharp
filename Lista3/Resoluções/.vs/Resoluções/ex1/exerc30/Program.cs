// Elabore um programa que converta a numeração Árabe em Romana.

using System.Net.Http.Headers;


Console.WriteLine("Escreva um número Árabe");
int num = Convert.ToInt32(Console.ReadLine());

string romano = "";

while (num != 0)
{
    if (num >= 1000)
    {
        romano += "M";
        num -= 1000;

    }
    else if (num >= 500)
    {
        romano += "D";
        num -= 500;
    }
    else if (num >= 100)
    {
        romano += "C";
        num -= 100;
    }
    else if (num >= 50)
    {
        romano += "L";
        num -= 50;
    }
    else if (num >= 10)
    {
        romano += "X";
        num -= 10;
    }
    else if (num >= 5)
    {
        romano += "V";
        num -= 5;
    }
    else if (num >= 1)
    {
        romano += "I";
        num -= 1;
    }
}

Console.WriteLine(romano);



