//Elabore um programa que imprima da tela um retângulo com o símbolo 'X' sabendo a sua largura e altura.

Console.WriteLine("Informe a altura do retângulo");
int alt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe a largura do retângulo");
int lar = Convert.ToInt32(Console.ReadLine());

if (lar <= alt)
    Console.WriteLine("Isso não é um retângulo");
else
{
    for (int i = 0; i < lar; i++)
        Console.Write("X");

    Console.WriteLine();

    for (int i = 0; i < alt - 2; i++)
    {
        for (int j = 0; j < lar; j++)
        {
            if (j == 0 || j == lar - 1)
                Console.Write("X");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < lar; i++)
        Console.Write("X");
}
