int[] A = {1,3,5,7,9};
int[] B = {2,4,6,8,10};
int[] C = new int[10];

int j = 0, k = 0;
for (int i = 0;i < 10; i++)
{
    if (i % 2 == 0) C[i] = A[j++];
    else C[i] = B[k++];

    Console.Write(C[i] + " ");
}

