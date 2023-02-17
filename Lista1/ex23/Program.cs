//Elabore um programa que troque entre si o valor contido em duas variáveis inteiras “a” e “b”, 
//ou seja, o valor contido em “a” passa a ser o valor de “b” e vice-versa, sem utilizar uma
//terceira variável.

Console.WriteLine("Informe o valor de a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de b");
int b = Convert.ToInt32(Console.ReadLine());

a = a * b;
b = a / b;
a = a / b;

Console.WriteLine("a = " + a + " b = " + b);