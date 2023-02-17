//Elabore um programa que calcule a hipotenusa de um triângulo retângulo 
//(utilizar o método Math.Sqrt)

// h2 = cat2 + cat2;

Console.WriteLine("Infome o valor dos dois catetos");
double cat1 = Convert.ToDouble(Console.ReadLine());
double cat2 = Convert.ToDouble(Console.ReadLine());

double h = Math.Pow(cat1, 2) + Math.Pow(cat2, 2);

h = Math.Sqrt(h);

Console.WriteLine("Valor da hipotenusa: " + h);
