//Qual é o menor múltiplo de 416 composto apenas pelos dígitos 1 e 2  1111222112


//long i = 1, digito, aux;

//do
//{
//    i++;
//    aux = 416 * i;

//    do
//    {
//        digito = aux % 10;
//        aux /= 10;
//    } while (aux != 0 && (digito == 1 || digito == 2));
//}while( aux !=0 || digito !=1 && digito != 2);

//Console.WriteLine("Resposta: " + 416 * i);


//resposta do chat gpt:
using System;

class MainClass
{
    static void Main()
    {
        int number = 416;
        int currentMultiple = number;

        while (true)
        {
            bool isMultiple = true;
            string currentMultipleStr = currentMultiple.ToString();

            foreach (char c in currentMultipleStr)
            {
                if (c != '1' && c != '2')
                {
                    isMultiple = false;
                    break;
                }
            }

            if (isMultiple)
            {
                Console.WriteLine("O menor múltiplo de 416 composto apenas pelos dígitos 1 e 2 é: " + currentMultiple);
                break;
            }

            currentMultiple += number;
        }
    }
}
