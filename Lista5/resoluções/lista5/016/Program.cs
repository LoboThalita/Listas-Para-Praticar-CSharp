int[] vet = { 2,4,9,8,5,6,7,3,1 };

for (int i = 0; i < vet.Length; i++)
{
    for (int j = 0; j < vet.Length; j++)
    {
        if (j +1 < vet.Length )
        {
            if (vet[j] < vet[j + 1])
            {
                int aux = vet[j];
                vet[j] = vet[j + 1];
                vet[j + 1] = aux;
            }
        }
    }
}

Console.WriteLine("Vetor ordenado em ordem decrescente");
for (int i = 0; i < vet.Length; i++)
{
    Console.Write(vet[i] + " ");
}