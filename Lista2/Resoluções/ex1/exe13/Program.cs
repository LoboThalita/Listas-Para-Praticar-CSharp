//Elabore um programa que determine as raízes de uma equação quadrática ax2 + bx + c = 0.

Console.WriteLine("Informe 3 números");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

double delta = Math.Pow(b, 2) - 4 * a * c;

double x1 = (- b + Math.Sqrt(delta)) / 2 * a;
double x2 = (-b - Math.Sqrt(delta)) / 2 * a;

Console.WriteLine( "As raizes da equação: " + a + "x^2 + " + b + "x + " + c + " = 0 são: ");
Console.WriteLine(x1);
Console.WriteLine(x2);