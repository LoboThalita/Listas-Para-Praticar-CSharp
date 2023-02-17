//Elabore um programa que apresente os números 4,68805; 4,8; 5,9964; e 5 arredondados 
//em três linhas diferentes, sendo que a primeira linha aparecem todos arredondados 
//considerando três casas decimais,na segunda duas e na terceira uma casa decimal.

double x = 4.68805;
double y = 4.8;
double z = 5.9964;
double t = 5;

Console.WriteLine(x.ToString("N3") + " " + y.ToString("N3") + " " + z.ToString("N3") + " " + t.ToString("N3"));
Console.WriteLine(x.ToString("N2") + " " + y.ToString("N2") + " " + z.ToString("N2") + " " + t.ToString("N2"));
Console.WriteLine(x.ToString("N1") + " " + y.ToString("N1") + " " + z.ToString("N1") + " " + t.ToString("N1"));


//OUTRA FORMA DE FAZER: não funciona muito bem, porque ele não respeita totalmente o número de casas decimais
//Console.WriteLine(Math.Round(x, 3) + " " + Math.Round(y, 3) + " " + Math.Round(z, 3) + " " + Math.Round(t, 3)) ;
//Console.WriteLine(Math.Round(x, 2) + " " + Math.Round(y, 2) + " " + Math.Round(z, 2) + " " + Math.Round(t, 2));
//Console.WriteLine(Math.Round(x, 1) + " " + Math.Round(y, 1) + " " + Math.Round(z, 1) + " " + Math.Round(t, 1));