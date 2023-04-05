Console.WriteLine("Informe o número de linhas e colunas da matiz respectivamente");
int linha = Convert.ToInt32(Console.ReadLine());
int coluna = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o valor do escalar");
int x = Convert.ToInt32(Console.ReadLine());

int[,] mat = new int[linha, coluna];


for (int i = 0;i < linha; i++)
{
    for(int j = 0; j < coluna; j++)
    {
        Console.WriteLine($"Informe o valor da posição {i}{j} da matriz");
        mat[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine("Matriz informada: ");
for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.Write(mat[i, j] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Matriz multiplicada pelo escalar: ");
for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        mat[i, j] *= x;
        Console.Write(mat[i,j] + "  ");
    }
    Console.WriteLine();
}