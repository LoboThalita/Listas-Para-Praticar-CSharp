using ex031;

int[] vet = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine("Informe o valor que deseja encontrar");
int valor = Convert.ToInt32(Console.ReadLine());

BuscaBRecursiva x = new();

int indice = x.BuscaRecursiva(vet, valor, 0, vet.Length - 1);

if (indice == -1)
    Console.WriteLine("Valor não encontrado");
else
    Console.WriteLine($"O valor {valor} foi encontrado no indice {indice}.");