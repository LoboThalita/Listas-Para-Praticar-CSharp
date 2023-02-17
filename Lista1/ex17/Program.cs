//Altere o programa anterior o qual deverá permitir que o valor da taxa do ICMS seja também um valor 
//fornecido pelo usuário.

Console.WriteLine("Informe o Preço base do produto: ");
double Pb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a porcentagem da taxa ICMS");
double i = Convert.ToDouble(Console.ReadLine());

double Pp = Pb * (i / 100 + 1);

Console.WriteLine("Preço de venda: " + Pp);
