Console.WriteLine("Informe o número de linhas das matrizes");
int linha = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o número de colunas das matrizes");
int coluna = Convert.ToInt32(Console.ReadLine());

int[,] m1 = new int[linha, coluna];
int[,] m2= new int[linha, coluna];
int[,] m3= new int[linha, coluna];

for ( int i = 0; i < linha;i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.WriteLine($"Informe o elemento da posição {i}{j} da primeira matriz");
        m1[i,j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.WriteLine($"Informe o elemento da posição {i}{j} da segunda matriz");
        m2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Soma das duas matrizes: ");
for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        m3[i,j] = m1[i,j]  + m2[i,j];
        Console.Write(m3[i,j] + " ");
    }
    Console.WriteLine();
}