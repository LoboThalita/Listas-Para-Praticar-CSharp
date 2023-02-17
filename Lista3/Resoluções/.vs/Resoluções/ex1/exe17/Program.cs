//Elabore um programa que imprima uma árvore de '*

using System.Xml;

void Espaco(int valor)
{
    for (int i = 0; i < valor; i++)
        Console.Write(" ");
}

void Estrela(int valor)
{
    for (int i = 0; i < valor; i++)
    {
        Console.Write("*");
    }
}

Console.WriteLine("Informe o tamanho da arvore ( min 9 )");
int x = Convert.ToInt32(Console.ReadLine());

int f = (x / 3) * 2, y = 1, t, aux, g = x - f;

aux = f;

if (x >= 9)
{
    //Parte de cima
    for (int i = 1; i <= f; i++)
    {
        Espaco(aux - 1);
        Estrela(y);
        aux--;
        y += 2;
        Console.WriteLine();
    }

    t = (y / 3);

    //tronco
    for (int i = 1; i < g + 1; i++)
    {
        Espaco(t);
        Estrela(t);
        Console.WriteLine();
    }
}
else Console.WriteLine("Selecione um número válido");


