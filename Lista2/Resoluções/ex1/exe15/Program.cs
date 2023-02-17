//Elabore um programa que determine o símbolo do zodíaco de uma pessoa baseado na 
//data do seu nascimento.

Console.WriteLine("Informe o dia do seu nascimento");
int dia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o mês do seu nascimento");
int mes = Convert.ToInt32(Console.ReadLine());

if (dia > 0)
    switch (mes) {
        case 1:
            if (dia >= 1 && dia <= 19)
                Console.WriteLine("Capricórnio");
            if (dia > 19 && dia <= 31)
                Console.WriteLine("Aquario");
            if (dia > 31)
                Console.WriteLine("Selecione data válida");
            break;
        case 2:
            if (dia >= 1 && dia < 19)
                Console.WriteLine("Aquario");
            if (dia >= 19 && dia <= 29)
                Console.WriteLine("Peixes");
            if (dia > 29)
                Console.WriteLine("Seleciona data válida");
            break;
        case 3:
            if (dia >= 1 && dia <= 20)
                Console.WriteLine("Peixes");
            if (dia > 20 && dia <= 31)
                Console.WriteLine("Aries");
            if (dia > 31)
                Console.WriteLine("selecione data válida");
            break;
        case 4:
            if (dia >= 1 && dia <= 20)
                Console.WriteLine("Aries");
            if (dia > 20 && dia <= 30)
                Console.WriteLine("Touro");
            if (dia > 30)
                Console.WriteLine("selecione data válida");
            break;
        case 5:
            if (dia >= 1 && dia <= 20)
                Console.WriteLine("Touro");
            if (dia > 20 && dia <= 31)
                Console.WriteLine("Gemeos");
            if (dia > 31)
                Console.WriteLine("selecione data válida");
            break;
        case 6:
            if (dia >= 1 && dia <= 20)
                Console.WriteLine("Gemeos");
            if (dia > 20 && dia <= 30)
                Console.WriteLine("Cancer");
            if (dia > 30)
                Console.WriteLine("selecione data válida");
            break;
        case 7:
            if (dia >= 1 && dia <= 22)
                Console.WriteLine("Cancer");
            if (dia > 22 && dia <= 31)
                Console.WriteLine("Leao");
            if (dia > 31)
                Console.WriteLine("selecione data válida");
            break;
        case 8:
            if (dia >= 1 && dia <= 22)
                Console.WriteLine("Leao");
            if (dia > 22 && dia <= 31)
                Console.WriteLine("Virgem");
            if (dia > 31)
                Console.WriteLine("selecione data válida");
            break;
        case 9:
            if (dia >= 1 && dia <= 22)
                Console.WriteLine("Virgem");
            if (dia > 22 && dia <= 30)
                Console.WriteLine("Libra");
            if (dia > 30)
                Console.WriteLine("selecione data válida");
            break;
        case 10:
            if (dia >= 1 && dia <= 22)
                Console.WriteLine("Libra");
            if (dia > 22 && dia <= 31)
                Console.WriteLine("Escorpiao");
            if (dia > 31)
                Console.WriteLine("selecione data válida");
            break;
        case 11:
            if (dia >= 1 && dia <= 21)
                Console.WriteLine("Escorpiao");
            if (dia > 21 && dia <= 30)
                Console.WriteLine("Sagitario");
            if (dia > 30)
                Console.WriteLine("selecione data válida");
            break;
        case 12:
            if (dia >= 1 && dia <= 21)
                Console.WriteLine("Sagitario");
            if (dia > 21 && dia <= 31)
                Console.WriteLine("Capricornio");
            if (dia > 31)
                Console.WriteLine("selecione data válida");
            break;
        default: 
            Console.WriteLine("Selecione data válida");
            break;
    }
else
    Console.WriteLine("Selecione data válida");