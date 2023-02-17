// Qual é o menor número inteiro positivo, tal que, se retirarmos o algarismo das unidades e o colocarmos do 
//lado esquerdo, obtemos um número 5 vezes maior. Elabore um que resolva o problema proposto.

int num = 10, novoNum = 0;

do
{
    num++;
    novoNum = InverteUltimo(num);

} while (num * 5 != novoNum);

int InverteUltimo(int num)
{
    int novoNum = 0;

    //Transformando o número em um vetor de caracteres para facilitar a manipulação
    string s = new(num.ToString());
    char[] vet = s.ToCharArray();

    //Separando o último caracter
    char ultimo = vet[vet.Length - 1];

    int aux = vet.Length - 1;

    //Passando os outros números pra traz, para esvaziar o indice 0
    for (int i = 0; i < vet.Length - 1; i++)
    {
        vet[aux] = vet[aux - 1];
        aux--;
    }

    //Colocando o último caracter no indice 0
    vet[0] = ultimo;

    int exp = vet.Length - 1;

    //Transformando o vetor de caracter (vet[]) em um inteiro (novoNum)
    for (int i = 0; i < vet.Length; i++)
    {
        novoNum += int.Parse(vet[i].ToString()) * Convert.ToInt32(Math.Pow(10, exp));
        exp--;
    }

    return novoNum;
}

Console.WriteLine("Menor número inteiro positivo, tal que, se retirarmos o algarismo das unidades e o colocarmos do " +
    "lado esquerdo, obtemos um número 5 vezes maior: " + num);
