//Elabore um programa que leia o preço base de um determinado produto e 
//calcule o seu valor de venda ao público (ou seja, valor acrescido da taxa de ICMS a 23%).

Console.WriteLine("Informe o preço base do produto");
double Pb = Convert.ToDouble(Console.ReadLine());

double Pp = Pb * 1.23;

Console.WriteLine("Preço de venda ao público: " + Pp);