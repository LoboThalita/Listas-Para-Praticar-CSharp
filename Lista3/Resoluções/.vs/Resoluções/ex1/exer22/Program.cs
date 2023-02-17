// Altere o programa anterior permitindo ao usuário informar as populações e as taxas de crescimento 
//iniciais.Valide a entrada e permita repetir a operação.
int anos = 0;

Console.WriteLine("Informe a população do país A e do país B");
double A = Convert.ToDouble(Console.ReadLine());
double B = Convert.ToDouble(Console.ReadLine());

if (A > 0 && B > 0)
{
    Console.WriteLine("Informe a taxa de crescimento do país A e do país B");
    double iA = Convert.ToDouble(Console.ReadLine());
    double iB = Convert.ToDouble(Console.ReadLine());

    if (A < B)
    {
        while (B > A)
        {
            A *= 1 + iA;
            B *= 1 + iB;
            anos++;
        }
    }
    else
    {
        while (A > B)
        {
            A *= 1 + iA;
            B *= 1 + iB;
            anos++;
        }
    }

    Console.WriteLine("Quantidade de anos necessários: " + anos);
    Console.WriteLine("População de A:" + Convert.ToInt32(A));
    Console.WriteLine("População de B:" + Convert.ToInt32(B));
}
else Console.WriteLine("Informe país válido");

