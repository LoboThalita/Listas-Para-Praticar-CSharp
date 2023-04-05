
using ex2;

Empregado emp1 = new("Joana", 7500.87, new DateTime(2010, 12, 25));


Console.WriteLine("Usando DeepCopy():");
Empregado emp2 = emp1.DeepCopy();
emp2.nome = "Miguel";
emp2.salario = 10200;
emp2.dataDeAdmissao = new DateTime(2008, 1, 1);

emp1.ToString();
emp2.ToString();


Console.WriteLine("Usando ShallowCopy():");
Empregado emp3 = emp1;
emp3.nome = "Miguel";
emp3.salario = 10200;
emp3.dataDeAdmissao = new DateTime(2008, 1, 1);

emp1.ToString();
emp3.ToString();