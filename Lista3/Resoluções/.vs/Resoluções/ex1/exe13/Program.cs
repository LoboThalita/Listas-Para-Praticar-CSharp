// Elabore um programa apresente os “n” termos da seguinte série: S = 1/1 + 2/3 + 3/5 + 4/7 + 5/9 + ... + n / m
//.Imprima no final a soma da série.

Console.WriteLine("Informe o valor de n");
int n = Convert.ToInt32(Console.ReadLine());

double m = 1, soma = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write(i + "/" + m );

    if (i != n) Console.Write(" + ");
    else Console.WriteLine();

    soma += (i/m);

    m += 2;
}

Console.WriteLine("Resultado da soma: " + soma);