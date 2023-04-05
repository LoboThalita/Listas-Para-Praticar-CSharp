using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class Retangulo : FormaGeometrica
    {
        public double largura { get; set; }
        public double comprimento { get; set; }

        public Retangulo(double largura, double comprimento)
        {
            this.largura = largura;
            this.comprimento = comprimento;
        }

        public override double Area()
        {
            return this.largura * this.comprimento;
        }

        public override double Perimetro()
        {
            return this.largura * 2 + this.comprimento * 2;
        }

        public override string ToString()
        {
            return $"Retangulo\nLargura: {this.largura}\nComprimento: {this.comprimento}\n"+ base.ToString() ;
        }
    }
}
