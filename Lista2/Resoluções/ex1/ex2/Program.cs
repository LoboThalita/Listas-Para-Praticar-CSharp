//Elabore um programa que converta um valor real positivo para um inteiro, considerando o 
//arredondamento.

Console.WriteLine("Informe um valor real positivo");
double x = Convert.ToDouble(Console.ReadLine());

x = Convert.ToInt32(x);

Console.WriteLine("valor convertido para inteiro: " + x);