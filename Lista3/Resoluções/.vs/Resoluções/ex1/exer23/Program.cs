//Elabore um programa que calcule o número médio de alunos por turma. Para isto, solicite a quantidade de 
//turmas e a quantidade de alunos de cada turma. As turmas não podem ter mais de 30 alunos.

Console.WriteLine("Informe o número de turmas");
int N = Convert.ToInt32(Console.ReadLine());

int soma = 0, quant=0;
double media;

for (int i = 0;i < N; i++)
{
    Console.WriteLine($"Informe a quantidade de alunos na {i+1}° turma");
    quant = Convert.ToInt32(Console.ReadLine());

    if (quant <= 30)
    {
        soma += quant;
    }
    else
    {
        Console.WriteLine("Turma inválida");
        i--;
    }       
}

media = soma / N;

Console.WriteLine("Número médio de alunos em turma: " + media);
