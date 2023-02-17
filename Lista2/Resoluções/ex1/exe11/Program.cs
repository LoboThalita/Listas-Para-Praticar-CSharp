//Elabore um programa que leia três valores inteiros e determine se estes podem 
//corresponder aos lados de um triângulo. Além disse, se os valores correspondem 
//aos lados de um triângulo, este deve ser classificado como equilátero, 
//isósceles ou escaleno. Nota: um triângulo é uma forma geométrica composta de três 
//lados e o valor de cada lado deve ser menor que a soma dos valores dos outros dois 
//lados.

//equilatero a = b = c
//isóceles a = b ou b = c ou a = c
//escaleno a != b != c

Console.WriteLine("Informe os 3 números");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c)
{
    if (b < c + a)
    {
        if (c < a + b)
        {
            Console.WriteLine("Corresponde a um triangulo");

            if (a == b && a == c)
            {
                Console.WriteLine("Do tipo : Equilatero");
            }
            else
            {
                if (a == b || a == c || c == b)
                {
                    Console.WriteLine("Do tipo: Isóceles");
                }
                else
                    Console.WriteLine("Do tipo: Escaleno");
            }
        }
        else
            Console.WriteLine("Não corresponde a um triangulo");
    }
    else
        Console.WriteLine("Não corresponde a um triangulo");

}
else
    Console.WriteLine("Não corresponde a um triangulo");
