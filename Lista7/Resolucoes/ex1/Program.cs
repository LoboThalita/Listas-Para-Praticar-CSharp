using ex1;

int soma = 0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Informe o nome do {i+1}º aluno");
    string nome = Console.ReadLine();

    Console.WriteLine($"Informe a idade do {i + 1}° aluno");
    int idade = Convert.ToInt32(Console.ReadLine());

    Aluno aluno = new(nome, idade);

    soma += aluno.idade;
}

double media = (double)soma/3;

Console.WriteLine("Média das idades: " + media);