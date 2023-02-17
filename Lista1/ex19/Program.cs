//Elabore um programa que apresente ao usuário a sua idade daqui a vinte anos

Console.WriteLine("informe sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Daqui 20 anos você terá: " + (int)(idade + 20));