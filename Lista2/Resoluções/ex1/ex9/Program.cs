//Elabore um programa que apresente na tela por ordem crescente três números introduzidos pelo usuário.

double[] valores = new double[3];
double aux = 0;

Console.WriteLine("Informe 3 números");
for (int i = 0; i < 3; i++)
{
    valores[i] = Convert.ToDouble(Console.ReadLine());
}

for (int i = 0; i < 2; i++)
{
    if (valores[i] > valores[i + 1])
    {
        aux = valores[i];
        valores[i] = valores[i + 1];
        valores[i + 1] = aux;
    }
}

if (valores[0] > valores[1])
{
    aux = valores[0];
    valores[0] = valores[1];
    valores[1] = aux;
}

Console.WriteLine("Em ordem crescente:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(valores[i]);
}