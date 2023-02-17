//Elabore um programa que converta dólares americanos em euros.

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Informe o valor em dólares americanos");
double dol = Convert.ToDouble(Console.ReadLine());

double eur = dol * 0.92;

Console.WriteLine(dol + " dólares correspondem a " + eur + " euros.");
