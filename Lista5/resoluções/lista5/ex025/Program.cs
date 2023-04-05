Console.WriteLine("Qual a quantidade de nomes que deseja armazenar?");
int quant = Convert.ToInt32(Console.ReadLine());

string[] nomes = new string[quant];

for (int i = 0;i < quant; i++)
{
    Console.Write($"{i+1}° nome: ");
    nomes[i] = Console.ReadLine();
    Console.WriteLine();
}

Console.WriteLine("qual posição do nome que deseja encontrar?");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Nome da {n}° posição: {nomes[n-1]}");