//Elabore um programa que calcule o salário semanal a pagar a um empregado, considerando que todas as 
//horas que este trabalha além das 40 horas serão pagas em dobro. Solicite do usuário os valores de horas 
//trabalhadas e o valor do salário por hora.

Console.WriteLine("Informe o número de horas trabalhadas");
int horas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor do salario por hora");
double salario = Convert.ToDouble(Console.ReadLine());

double total = 0;

if (horas > 40)
{
    horas -= 40;

    total = salario * 40 + salario * horas * 2;
}
else
{
    total = salario * horas;
}

Console.WriteLine("Salario total obtido: " + total);