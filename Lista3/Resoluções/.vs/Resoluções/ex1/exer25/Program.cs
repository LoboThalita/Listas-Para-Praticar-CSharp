// Elabore um programa que converta um número decimal em binário.

Console.WriteLine("Informe um número");
int dec = Convert.ToInt32(Console.ReadLine());

string rest = "";

while(dec > 0)
{   
    rest += dec % 2;
    dec = dec/2;
}
string bin = new string(rest.Reverse().ToArray());

Console.WriteLine(bin);