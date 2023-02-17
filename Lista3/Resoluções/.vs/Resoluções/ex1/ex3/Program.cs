////Elabore um programa que calcule a soma, com incrementos de 3, de todos os números menores que 100,
//começando em 4 (ex.: 4 + 7 + 10 + 13 + ...), utilizando as três estruturas de repetição:
//a.Com a estrutura for
//b. Com a estrutura while
//c. Com a estrutura do...while

int soma = 0;
int i;
//for
for( i = 4; i < 100; i += 3)
{
     soma += i;
}
Console.WriteLine("Resultado com for: " + soma);

soma = 0;

//while
i = 4;
while(i < 100){
    soma += i;
    i += 3;
}
Console.WriteLine("Resultado com while: " + soma);

//do while

i = 4;
soma = 0;

do
{
    soma += i;
    i += 3;
} while (i < 100);
Console.WriteLine("Resultado com do while: " + soma);