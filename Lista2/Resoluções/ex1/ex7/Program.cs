//Elabore um programa que utilizando um operador ternário, apresente na tela uma mensagem
//“Parabéns”se um aluno teve nota superior a 10 (dez inteiros) e “Faça um novo exame”,
//caso contrário.

Console.WriteLine("Informe a nota do aluno");
double nota = Convert.ToDouble(Console.ReadLine());

string result;

result = nota > 10 ? "Parabéns" : "Faça um novo exame";

Console.WriteLine(result);