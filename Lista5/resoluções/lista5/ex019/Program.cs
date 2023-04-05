int[,] mat = new int[2, 5];


for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.WriteLine($"Informe o valor da posição {i},{j}");
        mat[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

int maior = 0;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (maior < mat[i, j]) maior = mat[i, j];
    }
}

Console.WriteLine("O maior elemento da matriz é: " + maior);
