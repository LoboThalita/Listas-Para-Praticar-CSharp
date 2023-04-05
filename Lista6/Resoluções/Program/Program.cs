using Lista6.Exercicios;
int opc = 0;
do
{
    Console.WriteLine("Selecione o exercício. [0] para sair");
    opc = Convert.ToInt32(Console.ReadLine());

    switch (opc)
    {
        case 0: break;
        case 1: ex001.Executar(); break;
        case 2: ex002.Executar(); break;
        case 3: ex003.Executar(); break;
        case 4: ex004.Executar(); break;
        case 5: ex005.Executar(); break;
        case 6: ex006.Executar(); break;
        case 7: ex007.Executar(); break;
        case 8: ex008.Executar(); break;
        case 9: ex009.Executar(); break;
        case 10: ex010.Executar(); break;
        case 11: ex011.Executar(); break;
        case 12: ex012.Executar(); break;
        case 13: ex013.Executar(); break;
        case 14: ex014.Executar(); break;
        case 15: ex015();          break;
        case 16: ex016.Executar(); break;
        case 17: ex017.Executar(); break;
        case 18: ex018.Executar(); break;
        case 19: ex019();          break;
        default: Console.WriteLine("Opção inválida"); break;
    }
    Console.WriteLine();
    Console.WriteLine();
} while (opc != 0);

static void ex015()
{
    Console.WriteLine("informe duas strings");
    string p1 = Console.ReadLine();
    string p2 = Console.ReadLine();
    Lista6.Exercicios.ex015.Executar(p1, p2);
}
static void ex019()
{
    Console.WriteLine("Informe a string");
    string frase = Console.ReadLine();

    Console.WriteLine("Informe o valor de X");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    string encriptada = Lista6.Exercicios.ex019.Encriptar(frase.ToCharArray(), x);
    string desencriptada = Lista6.Exercicios.ex019.Desencriptar(encriptada.ToCharArray(), x);

    Console.WriteLine("Mensagem encriptada:");
    Console.WriteLine(encriptada);

    Console.WriteLine("\nMensagem desencriptada: ");
    Console.WriteLine(desencriptada);
}

