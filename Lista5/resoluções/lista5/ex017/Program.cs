
int[,] mat = new int[4,3] { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 },{ 1,5,9} };

int[,] mat2 = new int[4, 4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (j != 3)
            mat2[i,j] = mat[i,j];
        else
            for(int k = 0; k < 3; k++)
            {
                mat2[i,j] += mat[i, k];
            }
    }
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(mat2[i,j] + " ");
    }
    Console.WriteLine();
}