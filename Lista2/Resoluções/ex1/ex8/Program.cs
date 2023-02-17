//Elabore um programa que verifique se um determinado ano introduzido é bissexto.

Console.WriteLine("Informe um ano");
int ano = Convert.ToInt32(Console.ReadLine());

if (ano % 4 == 0)
    Console.WriteLine("O ano " + ano + " é bissexto");
else
    Console.WriteLine("O ano " + ano + " não é bissexto");