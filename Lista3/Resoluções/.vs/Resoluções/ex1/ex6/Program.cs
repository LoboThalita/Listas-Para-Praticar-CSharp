//Elabore um programa que peça dois números, base e expoente, calcule e apresente o primeiro número
//elevado ao segundo número. Não utilize o método Pow(), da linguagem C#.

Console.WriteLine("Informe um número");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("informe outro número");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{x} elevado a {y}: ");

int result = 1;

for (int i = 1; i <= y; i++)
    result *= x;

Console.WriteLine(result);


