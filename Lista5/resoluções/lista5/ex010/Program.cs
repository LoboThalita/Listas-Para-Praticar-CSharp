char[] A = new char[5] { 'A', 'B', 'C', 'D', 'E' };
int[] B = new int[5] { 1, 2, 3, 4, 5 };

for (int i = 0; i < A.Length; i++)
{
    for (int j = 0; j <B[i]; j++)
    {
        Console.Write(A[i]);
    }
    Console.WriteLine();
}