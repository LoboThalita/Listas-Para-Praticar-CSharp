//Elabore um programa que determine o mínimo múltiplo comum (MMC) de dois números.


Console.WriteLine("Informe dois números");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());

int[] primos = new int[7] { 2, 3, 5, 7, 11, 13, 17 };

int i = 0, result = 1;
bool div1, div2;

while (n1 != 1 || n2 != 1)
{
    if (n1 % primos[i] == 0)
    {
        n1 /= primos[i];
        div1 = true;
    }
    else div1 = false;

    if (n2 % primos[i] == 0)
    {
        n2 /= primos[i];
        div2 = true;
    }
    else div2 = false;

    if (div1 == false && div2 == false) i++;
    else result *= primos[i];
}

Console.WriteLine(result);
Console.ReadKey();
