using System.Runtime.CompilerServices;

int linha = 10, coluna = 3;

int[,] mat = new int[linha, coluna];
int maior = 0;
for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        if (j == 0)
        {
            Console.WriteLine($"Informe o valor da linha {i}");
            mat[i, j] = Convert.ToInt32(Console.ReadLine());
            if (mat[i, j] > 100)
            {
                Console.WriteLine("Número inválido");
                Environment.Exit(0);
            }
        }
        if (j == 1)
            mat[i, j] = mat[i, 0] * mat[i, 0]; ;
        if (j == 2)
            mat[i, j] = mat[i, 0] * mat[i, 0] * mat[i, 0];

    }

}

Console.WriteLine("Matriz gerada: ");

for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.Write(mat[i, j] + "    ");
        if (mat[i, j] > 1000)
            maior++;
    }
    Console.WriteLine();
}

Console.WriteLine("Quantida de posições da Matriz com valores acima de 1000: " + maior);