int DiasVividos()
{
    DateTime MeuNascimento = new(2001, 02, 24);
    DateTime agora = DateTime.Now;

    TimeSpan dias = agora - MeuNascimento;

    return dias.Days;
}

Console.WriteLine($"Eu já vivi {DiasVividos()} dias");