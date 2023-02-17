using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    // Elabore e teste um método que escreva "Olá, <nome>".
    public class ex01
    {
        public void Saudacao(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }
    }

    //Elabore e teste um método que devolva o resultado da soma de dois números inteiros.
    public class ex02
    {
        public int soma(int x, int y)
        {
            return x + y;
        }
    }

    //Elabore e teste um método que imprima na tela uma linha com “n” asteriscos, em que “n” é um número
    //fornecido pelo usuário.
    public class ex03
    {
        public void imprime()
        {
            Console.WriteLine("Informe um número");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //Elabore um programa que utilizando o método do exercício(3), imprima “m” linhas em que “m” é um
    //número inteiro fornecido pelo usuário
    public class ex04
    {
        public void imprime()
        {
            Console.WriteLine("Digite o número de linhas");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                ex03 ex3 = new();
                ex3.imprime();
            }
        }
    }

    //Elabore um programa que simule uma máquina de calcular, de número inteiros, em que cada ima das
    //operações, soma, subtração, multiplicação e divisão seja implementada através de um método.
    public class ex05
    {
        public int x;
        public int y;
        public ex05(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Som()
        {
            int soma = x + y;
            Console.WriteLine("Soma: " + soma);
        }
        public void Sub()
        {
            int sub = x - y;
            Console.WriteLine("Subtração: " + sub);
        }
        public void Mul()
        {
            int mul = x * y;
            Console.WriteLine("Multiplicação: " + mul);
        }
        public void Div()
        {
            int div = x / y;
            Console.WriteLine("Divisão: " + div);
        }
    }

    //Elabore e teste um método que retorne o maior entre dois valores.
    public class ex06
    {

        public void Maior()
        {
            Console.WriteLine("Informe dois valores");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
                Console.WriteLine("Maior = " + x);
            else
                Console.WriteLine("Maior = " + y);
        }
    }

    //Elabore um método que leia e valide a classificação de um aluno numa prova escrita.A nota deverá estar
    //entre 0 (zero) e 20. Elabore um programa que invoque o método e valide a entrada das notas relativas a
    //10 alunos
    public class ex07
    {

        public void validacao()
        {
            Console.WriteLine("Informe a nota do aluno");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n <= 20) Console.WriteLine("Nota válida");
            else Console.WriteLine("Nota inválida");
        }
    }

    //Elabore e teste um método que devolva o valor da hipotenusa.O método recebe como parâmetros de
    //entrada os catetos do triângulo.
    public class ex08
    {

        public void hip(double cat1, double cat2)
        {
            double hip = Math.Pow(cat1, 2) + Math.Pow(cat2, 2);

            hip = Math.Sqrt(hip);

            Console.WriteLine("Hipotenusa = " + hip);
        }
    }

    //Geração de números primos:
    //    a.Elabore um método que verifique se um número inteiro positivo é par;
    //    b.Elabore um programa que utilize o método do item(a) para imprimir os primeiros “n” números
    //    pares, em que “n” é um número inteiro positivo inserido pelo usuário.
    public class ex09
    {

        public bool par(int n)
        {
            if (n % 2 == 0)
            {
                Console.Write(n + " ");
                return true;
            }
            else return false;
        }
    }

    //Geração de números primos:
    //    a.Elabore um método que verifique se um número inteiro positivo é primo;
    //    b.Elabore um programa que utilize o método o item(a) para imprimir os primeiros “n” números
    //  primos, em que “n” é um número inteiro positivo fornecido pelo usuário.
    public class ex010
    {

        public bool primo(int n)
        {
            int quant = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) quant++;
            }

            if (quant == 2)
            {
                Console.Write(n + " ");
                return true;
            }
            else return false;
        }
    }

    //Elabore e teste um método que receba, como argumento, um valor inteiro positivo e devolva o número de
    //dígitos desse valor.
    public class ex011
    {

        public void digitos(int n)
        {
            int quant = 0;

            while (n != 0)
            {
                n /= 10;
                quant++;
            }

            Console.WriteLine("Quantiade de digitos = " + quant);
        }
    }

    //Elabore e teste um método que leia um conjunto de números inteiros e devolva o número de vezes que o
    //valor máximo surgiu.A dimensão da sequência é passada por parâmetro.
    public class ex012
    {

        public void QuantMax(int n)
        {
            int max = 0;
            int quant = 0;
            List<int> list = new();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informe o {i} ° número");
                int x = Convert.ToInt32(Console.ReadLine());
                list.Add(x);
                if (x > max) max = x;
            }

            foreach (int x in list)
            {
                if (x == max) quant++;
            }

            Console.WriteLine($"O valor maximo {max} aparece {quant} vezes");
        }
    }

    //Elabore um método que simule o lançamento de um dado.Este método não tem qualquer parâmetro de
    //entrada e devolve 1, 2, 3, 4, 5 ou 6. Utilize esse método num programa que simule “n” lançamentos de um
    //dado (“n” definido pelo usuário) e apresenta no final quantas vezes saiu a face 6.
    public class ex013
    {

        public void dado()
        {
            Random num = new();
            int num6 = 0;

            Console.WriteLine("Quantas vezes deseja jogar o dado?");
            int quant = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                int result = num.Next(1, 7);
                Console.WriteLine("Resultado: " + result);
                if (result == 6) num6++;
            }

            Console.WriteLine($"O número 6 caiu {num6} vezes");
        }
    }

    //Elabore e teste um programa que calcule os custos de expedição de uma encomenda, sabendo que o
    //envio do primeiro item tem um custo de R$ 5,00 e os itens seguintes têm um custo de R$ 1,00 (Exemplo: 
    //3 itens → R$ 5,00 + R$ 1,00 + R$ 1,00 = R$ 7,00). O método recebe por parâmetro de entrada o número
    //de itens.
    public class ex014
    {

        public void exped(int num)
        {
            int valor = 0;

            for (int i = 0; i < num; i++)
            {
                if (i == 0) valor += 5;
                else valor += 1;
            }

            Console.WriteLine("Custo de expedipção dos itens: " + valor);
        }
    }

    //Elabore e teste um método que calcule por recorrência potências de 2
    public class ex015
    {

        public void pot()
        {
            Console.WriteLine("Qual potencia de 2 deseja calcular?");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < n; i++)
            {
                result *= 2;
            }

            Console.WriteLine("Resultado: " + result);
        }
    }

}



