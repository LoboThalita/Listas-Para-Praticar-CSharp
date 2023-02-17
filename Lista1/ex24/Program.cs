//Elabore um programa que apresente na tela o antecessor e sucessor de um número introduzido pelo 
//usuário

Console.WriteLine("Informe um valor");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Antecessor: " + (int)(x - 1));
Console.WriteLine("Sucessor: " + (int)(x + 1));