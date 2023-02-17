//Elabore um programa que calcule a distância Euclidiana entre dois pontos P1 (x1, y1) e P2(x2, y2).

Console.WriteLine("Informe o X e o Y do primeiro ponto");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o X e o Y do segundo ponto");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double D = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);

D = Math.Sqrt(D);

Console.WriteLine("Distancia Euclidiana: " + D);
