//Elabore um programa que apresente na tela por extenso os dias da semana tendo em 
//conta a seguinte correspondência: 0 → Domingo; 1 → Segunda - Feira;
//2 → Terça - Feira; 3 → Quarta - Feira; 4 → QuintaFeira; 5 → Sexta - Feira;
//6 → Sábado.

Console.WriteLine("Escolha um dia da semana");
Console.WriteLine("0 → Domingo; 1 → Segunda - Feira;2 → Terça - Feira; 3 → Quarta - Feira; 4 → Quinta - Feira; 5 → Sexta - Feira; 6 → Sábado");
int opc = Convert.ToInt32(Console.ReadLine());

string dia;

switch (opc)
{
    case 0:
        dia = "Domingo";
        break;

    case 1:
        dia = "Segunda - Feira";
        break;

    case 2:
        dia = "Terça - Feira";
        break;

    case 3:
        dia = "Quarta - Feira";
        break;

    case 4:
        dia = "Quinta - Feira";
        break;

    case 5:
        dia = "Sexta - Feira";
        break;

    case 6:
        dia = "Sabado";
        break;

    default:
        dia = "Opção inválida";
        break;
}

Console.WriteLine(dia);