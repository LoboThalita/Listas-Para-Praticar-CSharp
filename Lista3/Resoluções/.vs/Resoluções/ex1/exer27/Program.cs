// Elabore um programa que calcule o total das entras a pagar num parque de diversões, sabendo que os 
//bilhetes para crianças até os 4 anos são grátis, dos 6 aos 12 são R$ 60,00, dos 12 aos 17 são R$ 120,00 
//e para os adultos são R$ 180,00. O programa deverá pedir ao usuário o número e tio de entradas.

Console.WriteLine("Quantidade de crianças de 0 até 4 anos:");
int C04 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantidade de crianças de 5 a 12 anos:");
int C512 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantidade de adolescentes de 13 a 17 anos:");
int A1317 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantidade de adultos 18+:");
int A18 = Convert.ToInt32(Console.ReadLine());

int Tot = C04 * 0 + C512 * 60 + A1317 * 120 + A18 * 180;

Console.WriteLine("Total a pagar: " + Tot);