//A partir das notas obtidas de um determinado aluno, verificar se o mesmo foi ou não 
//aprovado na disciplina de Algoritmos e Programação, sabendo que são realizadas duas 
//avaliações, cada uma com um peso de 10 pontos na nota final e, para aprovação 8.0 
//(oito inteiros) é considerado como nota mínima

Console.WriteLine("Informe o valor das duas provas");
double p1 = Convert.ToDouble(Console.ReadLine());
double p2 = Convert.ToDouble(Console.ReadLine());

double media = 0;

if (p1 > 10 || p2 > 10 || p1 < 0 || p2 < 0)
    Console.WriteLine("ERRO! Informe valor válido");
else
{
    media = (p1 + p2) / 2;

    if (media >= 8)
        Console.WriteLine("Aluno aprovado!");
    else
        Console.WriteLine("Aluno reprovado!");
}