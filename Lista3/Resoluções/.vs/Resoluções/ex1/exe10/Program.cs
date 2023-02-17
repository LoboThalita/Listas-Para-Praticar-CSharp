//Elabore um programa que leia um número inteiro e calcule a soma dos seus dígitos.

int soma = 0, digito = 0;

Console.WriteLine("Informe um número inteiro");
int n = Convert.ToInt32(Console.ReadLine());

while(n > 0)
{
    digito = n % 10;
    soma += digito;
    n /= 10;
}

Console.WriteLine("Soma dos digitos do número digitado: " + soma);