//Elabore um programa que solicite o lado do quadrado e imprima na tela a sua ária e perímetro

Console.WriteLine("Informe o lado do quadrado");
double lado = Convert.ToDouble(Console.ReadLine());

double area = lado * lado;

double per = lado * 4;

Console.WriteLine("Area do quadrado: " + area);
Console.WriteLine("Perimetro do quadrado: " + per);