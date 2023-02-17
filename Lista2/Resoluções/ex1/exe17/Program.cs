//Elabore um programa que avalie, utilizando o operador ternário, se um número é
//par ou ímpar.

Console.WriteLine("informe um número: ");
int x = Convert.ToInt32(Console.ReadLine());

string result;

result = x % 2 == 0 ? "Par" : "Impar";

Console.WriteLine("O número " + x + " é: " +result);