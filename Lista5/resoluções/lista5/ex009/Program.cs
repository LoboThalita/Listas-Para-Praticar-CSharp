using ex009;

int[] vet1 = new int[4] { 1, 2, 3, 4 };
int[] vet2 = new int[4] { 1, 2, 3, 4 };

int[] vet3 = new int[4] { 4, 3, 2, 1 };
int[] vet4 = new int[4] { 1, 2, 3, 4 };

vetIgual x = new vetIgual();

if (x.verifica(vet1, vet2))
    Console.WriteLine("Os vetores vet1 e vet2 são iguais");
else
    Console.WriteLine("Os vetores vet1 e vet2 não são iguais");

if (x.verifica(vet3, vet4))
    Console.WriteLine("Os vetores vet3 e vet4 são iguais");
else
    Console.WriteLine("Os vetores vet3 e vet4 não são iguais");
