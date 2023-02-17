// Elabore um programa que apresente e calcule a série S = 1/3 – 3/5 + 5/7 – 7/9 + 9/11... Sendo N o 
//número de termos da série informado pelo usuário.


Console.WriteLine("Informe o valor de N");
int n = Convert.ToInt32(Console.ReadLine());

double soma = 0, x = 1, y = 3;

for (int i = 0; i < n; i++)
{
    Console.Write(x + "/" + y);

    if (i % 2 == 0)
    {
        if (i != n - 1) Console.Write(" - ");
        soma += x / y;
    }
    else
    {
        if (i != n - 1) Console.Write(" + ");
        soma -= x / y;
    }

    x += 2;
    y += 2;
}
Console.WriteLine();
Console.WriteLine(soma);