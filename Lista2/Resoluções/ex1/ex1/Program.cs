//Elabore um programa que apresente na tela o resultado das operações lógicas:
//a) 4 == 5
//b) 4! = 6
//c) 4 > 5
//d) true == false
//e) 'a' == 'a'
//f) 'a' == 'b'
//g) 2 < 3 E 3 > 4
//h) 2 < 3 OU 3 > 4
//i) NÃO(2 < 3 OU 3 > 4)

Boolean x;

x = 4 == 5;
Console.WriteLine("4 == 5 : " + x);

x = 4 != 5;
Console.WriteLine("4 !=  5 : " + x);

x = 4 > 5;
Console.WriteLine("4 > 5 : " + x);

x = true == false;
Console.WriteLine("true == false : " + x);

x = 'a' == 'a';
Console.WriteLine("'a' == 'a' : " + x);

x = 'a' == 'b';
Console.WriteLine("'a' == 'b' : " + x);

x = 2 < 3 && 3 > 4;
Console.WriteLine("2 < 3 && 3 > 4 : " + x);

x = 2 < 3 || 3 > 4;
Console.WriteLine("2 < 3 || 3 > 4 : " + x);

x = !(2 < 3 || 3 > 4);
Console.WriteLine("!(2 < 3 || 3 > 4) : " + x);


