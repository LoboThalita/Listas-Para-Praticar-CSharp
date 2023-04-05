using ex003;

int[] v = new int[9] {9, 8, 1, 6, 8, 3, 8, 5, 6};

EncontraN x = new EncontraN();

int quant = x.encN(v);

Console.WriteLine($"Quantidade de vezes que o número aparece: {quant}");