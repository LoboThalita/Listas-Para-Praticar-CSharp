///Elabore um programa que calcule a média final de uma disciplina, arredondada a 0 (zero) 
//casas decimais, sabendo que essa disciplina possui duas avaliações (NP1 e NP2).

Console.WriteLine("Informe a nota da P1 e da P2");
int p1 = Convert.ToInt32(Console.ReadLine());
int p2 = Convert.ToInt32(Console.ReadLine());

int M = (p1 + p2) / 2;

Console.WriteLine("Média final: " + M);
