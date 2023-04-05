
using ex3;

void MostrarDados(FormaGeometrica forma)
{
    Console.WriteLine(forma.ToString());
}

Retangulo retangulo = new(12, 5);
Circunferencia circulo = new(5);

MostrarDados(retangulo);
MostrarDados(circulo);