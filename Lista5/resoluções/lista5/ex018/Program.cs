int[,] mat = new int[4, 3];

for(int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine($"Informe o valor da posição {i},{j}");
        mat[i,j] = Convert.ToInt32(Console.ReadLine()); 
    }
}

Console.WriteLine("Matriz informada");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(mat[i,j] + " ");
    }
    Console.WriteLine();
}