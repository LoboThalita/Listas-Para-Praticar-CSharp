//EXERCICIO 11

int[] vet = {3,5,8,5,1,5,6,9,9,6,5,2,1,3,3,5};
int[] frequencia = new int[vet.Length];

for (int i = 0; i < frequencia.Length; i++)
{
    int a = vet[i] - 1;
    frequencia[a]++;
}


for (int i = 0; i < frequencia.Length; i++)
{
    if (frequencia[i] > 0)
    {
        Console.WriteLine($"Frequencia de {i + 1}: {frequencia[i]}");
    }
}
Console.WriteLine();
Console.WriteLine();
//FIM DO EXERCICIO 11


int maxFreq = 0; //Maior frequencia
int maxVet = 0; //Maior número do vetor

for (int i = 0; i < frequencia.Length; i++)
{
    if (frequencia[i] > maxFreq) maxFreq = frequencia[i];
    if (vet[i] > maxVet) maxVet = vet[i];
}

Console.WriteLine("GRÁFICO DE ASTERISCOS\n");

for (int j = 0; j < maxFreq; j++)
{
    for (int i = 0; i < maxVet; i++)
    {
        if (frequencia[i] >= maxFreq)
            Console.Write("* ");
        else
        {
            Console.Write("  ");
            frequencia[i]++;
        }

    }
    Console.WriteLine();
}
for (int i = 0; i < maxVet; i++)
{
    Console.Write(i+1 + " ");
}

