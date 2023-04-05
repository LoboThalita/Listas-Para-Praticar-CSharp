Console.WriteLine("Informe o número de linhas e colunas da primeira matriz");
int linha1 = Convert.ToInt32(Console.ReadLine());
int coluna1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe o número de linhas e colunas da segunda matriz");
int linha2 = Convert.ToInt32(Console.ReadLine());
int coluna2 = Convert.ToInt32(Console.ReadLine());
s
if (coluna1 == linha2)
{
    int[,] m1 = new int[linha1, coluna1];
    int[,] m2 = new int[linha2, coluna2];
    int[,] m3 = new int[linha1, coluna2];

    Console.WriteLine("Preencha a primeria matriz:");
    PreencheMatriz(m1,linha1,coluna1);

    Console.WriteLine("Preencha a segunda matriz:");
    PreencheMatriz(m2,linha2,coluna2);

    Console.WriteLine("Resultado da multiplicação:");
    for (int i = 0; i < linha1; i++)
    {
        for (int j = 0; j < coluna2; j++)
        {
            for (int k = 0; k < coluna2; k++)
                m3[i, j] += m1[i, k] * m2[k, j];
            
            Console.Write(m3[i, j] + " ");
        }
        Console.WriteLine();
    }
}
else
    Console.WriteLine("Multiplicação impossivel");
void PreencheMatriz(int[,] m, int linha, int coluna)
{
    for (int i = 0; i < linha; i++)
    {
        for (int j = 0; j < coluna; j++)
        {
            Console.WriteLine(i + " " + j);
            m[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine();
}



