//Elabore um programa que implemente uma calculadora. A calculadora deverá ler do 
//usuário os dois números e a operação ( * ; + ; - ; / ) a realizar.

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("informe dois números");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha a operação");
Console.WriteLine("[1] +");
Console.WriteLine("[2] -");
Console.WriteLine("[3] *");
Console.WriteLine("[4] /");
int opr = Convert.ToInt32(Console.ReadLine());

double result =0;

switch (opr)
{
    case 1:
        result = x + y; break;
    case 2:
        result = x - y; break;
    case 3:
        result = x * y; break;
    case 4:
        result = x / y; break;
    default:
        Console.WriteLine("Escolha uma opção válida");
        break;
}

Console.WriteLine("Resultado: " + result);
