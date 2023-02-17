//O índice de massa corporal (IMC) obtém - se dividindo o peso pelo quadrado da altura. 
//Por exemplo, uma pessoa que tenha 71 kg e 1,67 metros de altura, tem 25,4 de IMC. 
//A Organização Mundial de Saúde (OMS) definiu as seguintes classificações:
//Classificação IMC Descrição
//1 IMC < 18,5 Abaixo do Peso
//2 18,5 <= IMC < 25 Peso Ideal
//3 25 <= IMC < 30 Obesidade Leve
//4 30 <= IMC < 40 Obesidade
//5 IMC >= 40 Obesidade Mórbida 
//Elabore um programa que leia a altura e o peso de um indivíduo e indique a 
//classificação em que este se enquadra.

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Informe o peso");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a altura");
double altura = Convert.ToDouble(Console.ReadLine());

double IMC = peso / Math.Pow(altura, 2);
string result = "";

if (IMC < 18.5)
    result = "Abaixo do Peso";
if (IMC >= 18.5 && IMC < 25)
    result = "Peso Ideal";
if (IMC >= 25 && IMC < 30)
    result = "Obesidade Leve";
if (IMC >= 30 && IMC < 40)
    result = "Obesidade";
if (IMC >= 40)
    result = "Obesidade Mórbida";

Console.WriteLine("Seu IMC é de: " + IMC);
Console.WriteLine(result);
