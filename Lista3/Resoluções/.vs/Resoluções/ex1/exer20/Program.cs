// Elabore um programa que solicite a 'n' pessoas de uma turma a sua idade. No final o programa deverá 
//verificar se a média de idade da turma varia entre 0 e 25, 26 e 60 e maior que 60; e então, dizer se a 
//turma é jovem, adulta ou idosa, conforme a média calculada

Console.WriteLine("Informe a quantidade de alunos");
int n = Convert .ToInt32(Console.ReadLine());

double soma = 0, media;
string tipo;

for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Qual a idade do {i+1}° aluno");
    soma+= Convert .ToDouble(Console.ReadLine());
}
media = soma / n;

if (media <= 25) tipo = "jovem";
else if (media <= 60) tipo = "adulta";
else tipo = "idosa";

Console.WriteLine("A turma é: " + tipo);