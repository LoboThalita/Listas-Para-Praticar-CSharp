using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lista6.Exercicios
{
    public static class ex001
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();

            Console.WriteLine($"\nOlá {nome}");
        }
    }

    public static class ex002
    {
        public static void Executar()
        {
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.Write("\nInforme o apelido: ");
            string apelido = Console.ReadLine();

            Console.WriteLine($"\nOlá {nome} {apelido}.");
        }
    }

    public static class ex003
    {
        public static void Executar()
        {
            string x = "Uma string qualquer";
            int indice = -1, i = 0;

            Console.WriteLine("Informe um caractere");
            char c = Convert.ToChar(Console.ReadLine());

            foreach (char a in x)
            {
                if (a == c)
                {
                    indice = i;
                    break;
                }
                i++;
            }
            if (indice == -1) Console.WriteLine("Caractere não encontrado");
            else Console.WriteLine($"Primeiro indice do caractere '{c}' na string '{x}': {indice}");
        }
    }

    public static class ex004
    {
        public static void Executar()
        {
            string x = "Uma string qualquer";
            int i = 0, quant = 0;

            Console.WriteLine("Informe um caractere");
            char c = Convert.ToChar(Console.ReadLine());

            foreach (char ch in x)
                if (ch == c) quant++;

            if (quant == 0) quant = -1;

            Console.WriteLine($"O caractere '{c}' aparece {quant} vezes na string: {x}");
        }
    }

    public static class ex005
    {
        public static void Executar()
        {
            Console.WriteLine("informe a primeria string");
            string s1 = Console.ReadLine();

            Console.WriteLine("Informe a segunda string");
            string s2 = Console.ReadLine();

            Console.WriteLine(s1 + " " + s2);
        }
    }

    public static class ex006
    {
        public static void Executar()
        {
            string x = "Uma string qualquer", nova = "";
            int j = 0;

            Console.WriteLine($"Informe o indice da string '{x}' que deseja inserir um caractere");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o caractere que deseja inserir");
            char c = Convert.ToChar(Console.ReadLine());

            foreach (char ch in x)
            {

                if (j == i) nova += c.ToString() + ch;
                else nova += ch;
                j++;
            }

            Console.WriteLine($"String '{x}' com o caractere '{c}' adicionado no indice {i}: {nova}");
        }
    }

    public static class ex007
    {
        public static void Executar()
        {
            string x = "Uma string qualquer", nova = "";
            int indice = 0;

            Console.WriteLine($"De qual a qual indice deseja substituir na tring '{x}'?");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o caractere");
            char c = Convert.ToChar(Console.ReadLine());

            foreach (char ch in x)
            {
                if (indice >= i && indice <= j) nova += "";
                else nova += ch.ToString();

                if (indice == j) nova += c.ToString();
                indice++;
            }

            Console.WriteLine("Nova string: " + nova);

        }
    }

    public static class ex008
    {
        public static void Executar()
        {
            string x = "Uma string qualquer", nova = "";

            foreach (char ch in x) nova += ch.ToString() + "*";

            Console.WriteLine(nova);
        }
    }

    public static class ex009
    {
        public static void Executar()
        {
            string x = "Uma string qualquer";

            x = x.ToUpper();

            Console.WriteLine(x);
        }
    }

    public static class ex010
    {
        public static void Executar()
        {
            string x = "Uma string qualquer";

            x = new string(x.Reverse().ToArray());

            Console.WriteLine(x);
        }
    }

    public static class ex011
    {
        public static void Executar()
        {
            string x = "Uma string qualquer", nova = "";
            int i = 0;

            foreach (char ch in x)
            {
                if (ch == ' ')
                {
                    x.ToArray();

                    for (int j = i + 1; j < x.Length; j++) nova += x[j];

                    break;
                }
                else nova += "";
                i++;
            }
            Console.WriteLine(nova);
        }
    }

    public static class ex012
    {
        public static void Executar()
        {
            string x = "Uma string qualquer", nova = "";
            int indice = 0, i = 0;

            EncontraUltimoEspaco(x, ref indice, i);

            x.ToArray();

            for (int j = 0; j < indice; j++)
                nova += x[j];

            Console.WriteLine(nova);
        }

        private static void EncontraUltimoEspaco(string x, ref int indice, int i)
        {
            foreach (char ch in x)
            {
                if (ch == ' ') indice = i;
                i++;
            }
        }
    }

    public static class ex013
    {
        public static void Executar()
        {
            string x = "Uma string qualquer", nova = "";
            int indice = 0, i = 0;

            EncontraUltimoEspaco(x, ref indice, i);

            x.ToArray();

            for (int j = indice + 1; j < x.Length; j++)
                nova += x[j];

            Console.WriteLine(nova);
        }

        private static void EncontraUltimoEspaco(string x, ref int indice, int i)
        {
            foreach (char ch in x)
            {
                if (ch == ' ') indice = i;
                i++;
            }
        }
    }

    public static class ex014
    {
        public static void Executar()
        {
            string p1 = "roma me tem amor", p2 = "uma string qualquer";

            if (verifica(p1)) Console.WriteLine($"A frase '{p1}' é um Palíndromo");
            else Console.WriteLine($"A frase '{p1}' não é um Palíndromo");

            if (verifica(p2)) Console.WriteLine($"A frase '{p2}' é um Palíndromo");
            else Console.WriteLine($"A frase '{p2}' não é um Palíndromo");

            bool verifica(string x)
            {
                x.ToArray();
                int j = x.Length - 1, quant = 0;

                for (int i = 0; i < x.Length / 2; i++)
                {
                    if (x[i] == x[j--]) quant++;
                }
                if (quant == x.Length / 2 - 1) return true;
                else return false;
            }
        }
    }

    public static class ex015
    {
        public static void Executar(string p1, string p2)
        {
            string nova = "";
            int j = 0, k = 0;

            p1.ToArray();
            p2.ToArray();

            if (p1.Length == p2.Length)
            {
                for (int i = 0; i < p1.Length * 2; i++)
                {
                    if (i % 2 == 0) nova += p1[j++];
                    else nova += p2[k++];
                }

                Console.WriteLine(nova);
            }
            else Console.WriteLine("Necessário duas strings com o mesmo tamanho");
        }
    }

    public static class ex016
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o nome completo");
            string nc = Console.ReadLine();

            string iniciais = "";

            nc.ToArray();
            iniciais += nc[0] + ".";
            for (int i = 0; i < nc.Length; i++)
                if (nc[i] == ' ') iniciais += nc[i + 1] + ".";

            Console.WriteLine(iniciais);
        }
    }

    public static class ex017
    {
        public static void Executar()
        {
            string p1 = "casa", p2 = "casamento";

            string resposta = verifica(p1, p2) ? $"{p1} é substring de {p2}" : $"{p1} não é substring de {p2}";
            Console.WriteLine(resposta);

            bool verifica(string p1, string p2)
            {
                p1.ToArray(); //sub
                p2.ToArray(); //string

                int x = 0;

                for (int i = 0; i < p2.Length; i++)
                {
                    for (int j = 0; j < p1.Length; j++)
                    {
                        if (p2[i] != p1[j]) break;
                        else
                        {
                            x++;
                            i++;
                        }
                    }
                }

                if (x == p1.Length) return true;
                else return false;
            }
        }
    }

    public static class ex018
    {
        public static void Executar()
        {
            int x = 0;

            Console.WriteLine("Registre o usuário");

            Console.Write("Usuário: ");
            string user = Console.ReadLine();

            Console.Write("Senha: ");
            string pass = Console.ReadLine();

            do
            {

                if (autenticar(user, pass))
                {
                    Console.WriteLine("Bem-Vindo ao sistema");
                    break;
                }
                else
                {
                    Console.WriteLine("Usuário ou senha incorretos. 1- Tentar novamente");
                    x = Convert.ToInt32(Console.ReadLine());
                }

            } while (x == 1);

            bool autenticar(string username, string password)
            {
                Console.WriteLine("\n\n Entre no sistema com o seu Usuário e senha");
                Console.Write("Usuário: ");
                string u = Console.ReadLine();

                Console.Write("Senha: ");
                string s = Console.ReadLine();

                if (u == username && s == password) return true;
                else return false;
            }
        }
    }

    public static class ex019
    {
        public static string Encriptar(char[] frase, int deslocamento)
        {
            string nova = "";
            int caracter_deslocado;

            foreach (int caracter_da_frase in frase)
            {
                caracter_deslocado = caracter_da_frase + deslocamento;
                if (EstaNoAlfabeto(caracter_da_frase))
                {
                    if (VerificaSeNaoUltrapassaZ(caracter_deslocado))
                        nova += (char)caracter_deslocado;
                    else
                        nova += (char)(caracter_deslocado - 26);
                }
                else nova += (char)caracter_da_frase;
            }
            return nova;
        }

        public static string Desencriptar(char[] frase, int deslocamento)
        {
            string nova = "";
            int caracter_deslocado;
            foreach (int caracter_da_frase in frase)
            {
                caracter_deslocado = caracter_da_frase - deslocamento;
                if (EstaNoAlfabeto(caracter_da_frase))
                {
                    if (VerificaSeNaoUltrapassaZ(caracter_deslocado))
                        nova += (char)caracter_deslocado;
                    else
                        nova += (char)(caracter_deslocado + 26);
                }
                else nova += (char)caracter_da_frase;
            }
            return nova;
        }
        //Funções auxiliares
        static bool EstaNoAlfabeto(int caracter_da_frase)
        {
            return caracter_da_frase >= 'a' && caracter_da_frase <= 'z' || caracter_da_frase >= 'A' && caracter_da_frase <= 'Z';
        }
        static bool VerificaSeNaoUltrapassaZ(int caracter_deslocado)
        {
            return caracter_deslocado <= 'z' && caracter_deslocado >= 'a' || caracter_deslocado <= 'Z' && caracter_deslocado >= 'A';
        }

    }
}

