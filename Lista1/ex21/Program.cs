//Elabore um programa que calcule a despesa média diária que um turista despendeu numa viagem 
//de quatro dias a Bélgica, sabendo que cada dia gastou mais 20% do que no dia anterior.
//O valor da despesa deverá ser apresentado sem casas decimais.

Console.WriteLine("Informe o total gasto no primeiro dia de viagem");
double G = Convert.ToDouble(Console.ReadLine());
double T = G;
for (int i = 1; i < 4; i++)
{
    G *= 1.2;
    T += G;
}
T = Convert.ToInt32(T);

Console.WriteLine("Total gasto nos 4 dias de viagem: " + T);