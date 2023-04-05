using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class Circunferencia : FormaGeometrica
    {
        public double raio { get; set; }

        public Circunferencia(double raio)
        {
            this.raio = raio;
        }

        public override double Area()
        {
            return 3.1416 * this.raio * this.raio;
        }

        public override double Perimetro()
        {
            return 2 * 3.1416 * this.raio; 
        }

        public override string ToString()
        {
            return $"Circunferência\nRaio: {this.raio}\n" + base.ToString();
        }
    }
}
