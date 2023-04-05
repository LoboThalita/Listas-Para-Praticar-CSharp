using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public abstract class FormaGeometrica
    {
        public string nome { get; set; }

        public abstract double Area();

        public abstract double Perimetro();

        public override string ToString()
        {
            return $"Área: {Area()}\nPerímetro:{Perimetro()}\n";
        }
    }
}
