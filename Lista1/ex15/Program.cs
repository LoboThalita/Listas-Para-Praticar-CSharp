//Elabore um programa que converta a temperatura lida em graus Fahrenheit para graus Celsius. 
//A fórmula é C = 5/9 * (f - 32).

Console.WriteLine("Informe o valor em graus Fahrenheit");
double F = Convert.ToDouble(Console.ReadLine());

double C = 0.5555556 * (F - 32);

Console.WriteLine(F + " graus Fahrenheit correspondem a " + C + " graus Celcius");