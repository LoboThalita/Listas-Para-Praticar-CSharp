int HorasRestantes()
{
    DateTime agora = DateTime.Now;
    DateTime fimDoDia = agora.Date.AddDays(1).AddTicks(-1);
    TimeSpan diferenca = fimDoDia - agora;
    return diferenca.Hours;
}

Console.WriteLine("Faltam " + HorasRestantes() + " horas para acabar o dia");
