//Elabore um programa que determine se um caractere introduzido pelo usuário é uma vogal 
//ou uma consoante.

Console.WriteLine("Informe uma letra");
char x = Convert.ToChar(Console.ReadLine());

if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
    Console.WriteLine("É vogal");
else
    Console.WriteLine("É consoante");