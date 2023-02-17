//Elabore um programa que apresente na tela o maior de três valores.

Console.WriteLine("Informe 3 valores");
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double x = 0;

if (a >= b && a >= c)
    x = a;

if (b >= a && b >= c)
    x = b;

if (c >= a && c >= b)
    x = c;

Console.WriteLine("O maior número incerido é : " + x);
