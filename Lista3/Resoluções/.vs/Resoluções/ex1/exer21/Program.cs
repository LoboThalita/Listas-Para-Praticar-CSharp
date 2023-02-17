// Supondo que a população do país A é de 80000 habitantes com uma taxa anual de crescimento de 3% e 
//que a população do país B é 200000 habitantes com uma taxa de crescimento de 1,5%. Elabore um 
//programa que calcule e escreva n número de anos necessários para que a população do país A 
//ultrapasse ou iguale a população do país B, mantidas as taxas de crescimento.

double A = 80000;
double iA = 0.03;
double B = 200000;
double iB = 0.015;
int anos =0;

while (B > A)
{
    A *= 1 + iA;
    B *= 1 + iB;
    anos++;
}

Console.WriteLine("Quantidade de anos necessários: " + anos);
Console.WriteLine("População de A:" + Convert.ToInt32(A));
Console.WriteLine("População de B:" + Convert.ToInt32(B));