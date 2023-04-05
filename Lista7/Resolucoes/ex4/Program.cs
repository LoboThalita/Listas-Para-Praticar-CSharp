int RetornaDia (DateTime data)
{
    return data.DayOfYear;
}

DateTime data = DateTime.Now;

Console.WriteLine($"O dia {data:dd/MM/yyyy} é o dia {RetornaDia(data)} do ano");