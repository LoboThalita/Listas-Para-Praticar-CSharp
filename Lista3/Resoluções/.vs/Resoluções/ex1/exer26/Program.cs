// Elabore um programa que converta um número binário num número inteiro

using System.ComponentModel;

Console.WriteLine("Informe um número binário");
double bin = Convert.ToDouble(Console.ReadLine());

double digito, dec = 0;
int i = 0;

while (bin >0) 
{
    digito = bin % 10;

    if (digito != 1 && digito !=0)
    {
        Console.WriteLine("Número BINÁRIO! Por favor.");
        break;
    }
    else
    {
        dec += digito * Math.Pow(2, i);
        i++;
        bin = Convert.ToInt32(bin) / 10;
    }
}

Console.WriteLine(dec);
