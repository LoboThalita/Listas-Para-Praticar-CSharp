//Num determinado stand de automóveis, os vendedores ganham um salário mensal base X, 
//uma comissão de Y reais por cada automóvel que vendem a uma percentagem P sobre o valor das
//vendas V que efetuarem. Elabore um programa que calcule e imprima na tela o salário que um 
//vendedor receberá este mês.

Console.WriteLine("Informe o salario mensal base");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a comissão em reais por automovel");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a porcentagem sobre o valor das vendas");
double p = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o total em reais das vendas");
double v = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a quantidade de carros vendidos");
int q = Convert.ToInt32(Console.ReadLine());

double total = x + y * q + v * p / 100;

Console.WriteLine("Salario do mes: " + total);
