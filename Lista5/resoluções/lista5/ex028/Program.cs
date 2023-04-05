using ex028;

int[] vet = { 2, 3, 5, 8, 9, 4, 6, 7, 1 };

Console.WriteLine("Vetor original: ");
for (int i = 0; i < vet.Length; i++)
    Console.Write(vet[i] + " ");

Console.WriteLine();

BubbleSort x = new BubbleSort();

x.ordena(vet);

Console.WriteLine("Vetor Ordenado: ");
for (int i = 0; i < vet.Length; i++)
    Console.Write(vet[i] + " ");