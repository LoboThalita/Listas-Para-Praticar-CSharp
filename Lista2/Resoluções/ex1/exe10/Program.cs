//Elabore um programa que calcule o valor total a pagar por determinado produto, 
//sabendo o tipo de produto e seu respectivo preço sem ICMS. Suponha que a taxa de ICMS 
//é de 5% para os bens essenciais, 30% para os produtos de luxo e 20% para os restantes.



Console.WriteLine("Informe o tipo do produto");
Console.WriteLine("[1] Bens essenciais");
Console.WriteLine("[2] Produtos de luxo");
Console.WriteLine("[3] Outro");
int tipo = Convert.ToInt32(Console.ReadLine());

if (tipo >= 1 && tipo <= 3)
{

    Console.WriteLine("Informe o preço do produto");
    double preco = Convert.ToDouble(Console.ReadLine());

    switch (tipo)
    {
        case 1:
            preco += preco * 0.05;
            break;

        case 2:
            preco += preco * 0.3;
            break;

        case 3:
            preco += preco * 0.2;
            break;

        default:
            Console.WriteLine("Informe opção válida");
            break;
    }

    Console.WriteLine("Preço calculado com ICMS: " + preco);

}
else
    Console.WriteLine("Infrome opção válida");
