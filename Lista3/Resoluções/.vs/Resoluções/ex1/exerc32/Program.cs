//Um número primo de Mersenne é um número de Mersenne (número da forma Mn = 2n – 1, com n um 
//número inteiro positivo) que também é um número primo. Elabore um programa que determine todos os 
//números de Mersenne até n = 61

long  num;

for(int n=2; n <= 61; n++)
{
    int quant = 0;
    for (long i = 2; i <= n; i++)
    {
        if (n % i == 0) quant++;
    }
    if (quant == 1)
    {
        num = (long)Math.Pow(2, n) - 1;

        int qnt = 0;
        for (long j = 2; j <= num; j++)
        {
            if (num % j == 0) qnt++;
        }
        if(qnt == 1)
            Console.WriteLine(num + " = 2 ^ " + n + " - 1");
    }
}