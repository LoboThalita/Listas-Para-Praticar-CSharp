using ex004;

indiceN x = new indiceN();

int[] v = new int[9] {9,8,1,6,8,3,8,5,6};

int i = x.indice(v);

Console.WriteLine("Indice da primeira vez que o número aparece: " + i);
