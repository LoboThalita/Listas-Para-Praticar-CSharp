
using ex015;

Console.WriteLine("Informe o tamanho dos dois vetores");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

int[] V1 = new int[n1];
int[] V2 = new int[n2];

Console.WriteLine("preencha o primeiro vetor:");
for (int i = 0; i < n1; i++)
{
    Console.WriteLine(i + 1 + "º: ");
    V1[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("preencha o segundo vetor:");
for (int i = 0; i < n2; i++)
{
    Console.WriteLine(i + 1 + "º: ");
    V2[i] = Convert.ToInt32(Console.ReadLine());
}

uniaoVet x = new();

x.unir(V1, V2);