using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public class Empregado
    {
        public string nome { get; set; }
        public double salario { get; set; }
        public DateTime dataDeAdmissao { get; set; }


        public Empregado(string nome, double salario, DateTime dataDeAdmissao)
        {
            this.nome = nome;
            this.salario = salario;
            this.dataDeAdmissao = dataDeAdmissao;
        }

        public void ToString()
        {
            Console.WriteLine($"Nome: {this.nome}\nSalário: {this.salario}\nData de Admissão: {dataDeAdmissao}\n"); 
        }

        public void AumentarSalario(double porcentagem)
        {
            double pct = porcentagem / 100;

            this.salario *= 1 + pct;
        }

        public Empregado DeepCopy()
        {
            Empregado copiaEmpregado = new Empregado(this.nome, this.salario, this.dataDeAdmissao);
            return copiaEmpregado;
        }
    }
}
