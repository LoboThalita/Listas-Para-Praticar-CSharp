int[] vetor = new int[10] {6,5,8,9,4,7,3,1,0,2};
int maior = 0, menor = 999, pMaior = 0, pMenor = 0;

for(int i = 0;i < vetor.Length; i++)
{
    if (vetor[i] > maior)
    {
        maior = vetor[i];
        pMaior = i;
    }

    if (vetor[i] < menor)
    {
        menor = vetor[i];
        pMenor = i;
    }
}

Console.WriteLine($"Maior número: {maior} Indice: {pMaior}\nMenor Número: {menor} Indice: {pMenor}");
