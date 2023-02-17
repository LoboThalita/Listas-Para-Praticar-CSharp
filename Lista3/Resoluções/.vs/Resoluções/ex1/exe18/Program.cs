//Elabore um programa que determine o máximo divisor comum (MDC) de dois números utilizando o 
//algoritmo de Euclides.

Console.WriteLine("Informe dois números");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int rest = 1, mdc = 0;

while (rest != 0)
{
    mdc = rest;
    rest = x % y;
    x = y;
    y = rest;
}

Console.WriteLine(mdc);