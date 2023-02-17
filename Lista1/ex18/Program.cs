//Elabore um programa que converta um valor em segundos para horas, minutos e segundos.

Console.WriteLine("Informe o tempo em segundos: ");
int seg = Convert.ToInt32(Console.ReadLine());

int H = seg / 3600;
seg -= H * 3600;

int Min = seg / 60;
seg -= Min * 60;

Console.WriteLine(H + " horas " + Min + " minutos e " + seg + " segundos.");
