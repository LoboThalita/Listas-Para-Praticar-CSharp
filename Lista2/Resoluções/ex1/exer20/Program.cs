//Elabore um programa que apresente na tela os dias de um mês 
//(janeiro, fevereiro, março etc.) introduzido pelo usuário. No mês de fevereiro 
//deverá apresentar 28 ou 29 dias

Console.WriteLine("Informe um mês");
int mes = Convert.ToInt32(Console.ReadLine());

int dias = 0;

switch (mes)
{
    case 1:
        dias = 31;
        break;
    case 2:
        dias = 28;
        break;
    case 3:
        dias = 31;
        break;
    case 4:
        dias = 30;
        break;
    case 5:
        dias = 31;
        break;
    case 6:
        dias = 30;
        break;
    case 7:
        dias = 31;
        break;
    case 8:
        dias = 31;
        break;
    case 9:
        dias = 30;
        break;
    case 10:
        dias = 31;
        break;
    case 11:
        dias = 30;
        break;
    case 12:
        dias = 31;
        break;
    default:
        dias = 0;
        break;
}
if (mes != 2)
    Console.WriteLine("O mês possui: " + dias + " dias.");
else
    Console.WriteLine("O mês possui: " + dias + " ou 29 dias.");