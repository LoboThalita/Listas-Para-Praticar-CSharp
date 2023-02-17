//Elabore um programa que imprima, em várias linhas, os 25 primeiros múltiplos de um dado número inteiro 
//introduzido pelo usuário. Cada uma das linhas escritas deve conter 5 múltiplos do número especificado.

Console.WriteLine("Informe um número inteiro");
int n = Convert.ToInt32(Console.ReadLine());

var mult = new List<int>();
int cont = 1;

for (int i = 1; i < n; i++)
{
    if (n % i == 0) mult.Add(i);
}

foreach(int i in mult)
{
    Console.Write(i + " ");
    if (cont % 5 == 0) Console.WriteLine();
    cont++;
    if (cont > 25) break;
}