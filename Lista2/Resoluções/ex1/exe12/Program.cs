//Elabore um programa que escreva os números de 0 (zero) a nove por extenso.


for (int i = 0; i <= 9; i++)
{
    string x = "";

    switch (i)
    {
        case 0:
            x = "Zero";
            break;

        case 1:
            x = "Um";
            break;

        case 2:
            x = "Dois";
            break;

        case 3:
            x = "Três";
            break;

        case 4:
            x = "Quatro";
            break;

        case 5:
            x = "Cinco";
            break;

        case 6:
            x = "Seis";
            break;

        case 7:
            x = "Sete";
            break;

        case 8:
            x = "Oito";
            break;

        case 9:
            x = "Nove";
            break;
    }

    Console.WriteLine(x);
}