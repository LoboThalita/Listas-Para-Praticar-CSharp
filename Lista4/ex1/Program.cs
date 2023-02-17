using exercicios;

void exercicio1()
{
    ex01 ex1 = new();
    Console.WriteLine("Qual o nome?");
    string nome = Console.ReadLine();
    ex1.Saudacao(nome);
}

void exercicio2()
{
    ex02 ex2 = new();
    Console.WriteLine("Digite dois números para somar");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(ex2.soma(x, y));
}

void exercicio3()
{
    ex03 ex3 = new();
    ex3.imprime();
}

void exercicio4()
{
    ex04 ex4 = new();
    ex4.imprime();
}

void exercicio5()
{
    Console.WriteLine("Informe dois números");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    ex05 ex5 = new(a, b);
    ex5.Som();
    ex5.Sub();
    ex5.Mul();
    ex5.Div();
}

void exercicio6()
{
    ex06 ex6 = new();
    ex6.Maior();
}

void exercicio7()
{
    ex07 ex7 = new();
    for (int i = 0; i < 10; i++)
        ex7.validacao();
}

void exercicio8()
{
    Console.WriteLine("Informe os dois catetos");
    double x = Convert.ToDouble(Console.ReadLine());
    double y = Convert.ToDouble(Console.ReadLine());

    ex08 ex8 = new();

    ex8.hip(x, y);
}

void exercicio9()
{
    ex09 ex9 = new();

    Console.WriteLine("Informe um número");
    int n = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int quant = 0;

    Console.WriteLine($"Primeiros {n} números pares: ");
    while (quant != n)
    {
        if (ex9.par(i++)) quant++;
    }
}

void exercicio10()
{
    ex010 ex10 = new();

    Console.WriteLine("Informe um número");
    int n = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int quant = 0;

    Console.WriteLine($"Primeiros {n} números primos: ");
    while (quant != n)
    {
        if (ex10.primo(i++)) quant++;
    }
}

void exercicio11()
{
    Console.WriteLine("Informe um número");
    int n = Convert.ToInt32(Console.ReadLine());

    ex011 ex11 = new();
    ex11.digitos(n);
}

void exercicio12()
{
    Console.WriteLine("Informe a dimensão da sequencia");
    int n = Convert.ToInt32(Console.ReadLine());

    ex012 ex12 = new();

    ex12.QuantMax(n);
}

void exercicio13()
{
    ex013 ex13 = new();
    ex13.dado();
}

void exercicio14()
{
    Console.WriteLine("Quantos itens deseja enviar? ");
    int n = Convert.ToInt32(Console.ReadLine());

    ex014 ex14 = new();

    ex14.exped(n);
}

void exercicio15()
{
    ex015 ex15 = new();

    ex15.pot();
}


Console.WriteLine("Qual exercicio deseja rodar? ");
int opc = Convert.ToInt32(Console.ReadLine());

switch (opc)
{
    case 1: exercicio1(); break;
    case 2: exercicio2(); break;
    case 3: exercicio3(); break;
    case 4: exercicio4(); break;
    case 5: exercicio5(); break;
    case 6: exercicio6(); break;
    case 7: exercicio7(); break;
    case 8: exercicio8(); break;
    case 9: exercicio9(); break;
    case 10: exercicio10(); break;
    case 11: exercicio11(); break;
    case 12: exercicio12(); break;
    case 13: exercicio13(); break;
    case 14: exercicio14(); break;
    case 15: exercicio15(); break;
    default: Console.WriteLine("Opção inválida"); break;
}
