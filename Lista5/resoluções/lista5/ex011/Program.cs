
int[] vet = { 1, 7, 7, 5, 8, 2, 7, 6, 5, 8 };
int[] frequencia = new int[vet.Length];

for (int i = 0; i < frequencia.Length; i++)
{
    int a = vet[i]-1;
    frequencia[a]++;
}
    

for (int i = 0; i < frequencia.Length; i++)
{
    if (frequencia[i] > 0)
    {
        Console.WriteLine($"Frequencia de {i+1}: {frequencia[i]}");
    }
}