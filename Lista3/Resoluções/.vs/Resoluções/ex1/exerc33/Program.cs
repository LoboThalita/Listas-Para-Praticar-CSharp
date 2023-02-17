//Qual é o menor múltiplo de 182 composto apenas pelo dígito 4?  444444

long num = 444;
while (num % 182 != 0)
{
    num = num * 10 + 4;
}

Console.WriteLine("Resposta: " + num);
