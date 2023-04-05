Console.WriteLine("Informe o número de linhas e colunas resapectivamente");
int linha = Convert.ToInt32(Console.ReadLine());
int coluna = Convert.ToInt32(Console.ReadLine());

int[,] m = new int[linha, coluna];
int[,] mt = new int[coluna, linha];

for( int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.WriteLine("Informe o valor da posição " + i + j);
        m[i,j] = Convert.ToInt32(Console.ReadLine());
        mt[j,i] = m[i,j];
    }
}

Console.WriteLine("Matriz informada: ");
for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        Console.Write(m[i,j] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine("Matriz transposta");

for (int i = 0; i < coluna; i++)
{
    for (int j = 0; j < linha; j++)
    {
        Console.Write(mt[i, j] + "  ");
    }
    Console.WriteLine();
}

