// Elabore um programa que leia uma sequência de números inteiros a partir do teclado e acumule 
//unicamente a soma dos inteiros positivos. O programa termina quando o número lido for zero.

int num = 1, soma = 0;

while (num != 0)
{
    Console.WriteLine("Informe um número. Caso queira parar, digite zero");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > 0)
        soma += num;
}

Console.WriteLine("Soma dos números positivos: " + soma);