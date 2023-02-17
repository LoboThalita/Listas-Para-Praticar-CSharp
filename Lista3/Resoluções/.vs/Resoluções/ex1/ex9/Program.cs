// Elabore um programa que peça a altura de “n” alunos de uma turma e apresente as seguintes estatísticas:
//a.A altura do aluno mais baixo;
//b.A altura do aluno mais alto;
//c.A soma das alturas;
//d.A média das alturas.

int quant = 0;
double alt = 0, soma = 0, maior = 0, menor = 999, media = 0 ;

Console.WriteLine("Quantos alunos há na sala?");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Informe a altura do {i + 1}° aluno");
    alt = Convert.ToDouble(Console.ReadLine());

    soma += alt;
    quant++;

    if(alt > maior) maior = alt;
    if(alt< menor) menor = alt;

}

media = soma / quant;

Console.WriteLine($"Altura do aluno mais baixo: {menor}");
Console.WriteLine($"Altura do aluno mais alto: {maior}");
Console.WriteLine($"Soma das alturas: {soma}");
Console.WriteLine($"Média das alturas: {media}");