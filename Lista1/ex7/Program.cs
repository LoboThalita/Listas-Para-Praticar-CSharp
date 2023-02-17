//Elabore um programa que leia do utilizador 3 números e os apresente alinhados à esquerda,
//na mesma linha, cada um com 10 casas.

Console.WriteLine("Digite 3 números: ");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());
double z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(string.Format("|{0,30}|{1,30}|{2,30}|", x.ToString("N10"), y.ToString("N10"), z.ToString("N10")));