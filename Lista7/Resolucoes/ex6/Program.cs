bool DiaUtil(DateTime data)
{
    return data.DayOfWeek != DayOfWeek.Sunday && data.DayOfWeek != DayOfWeek.Saturday;
}

DateTime data = DateTime.Now;

if (DiaUtil(data))
    Console.WriteLine($"O dia {data:dd/MM/yyyy} é um dia util");
else
    Console.WriteLine($"O dia {data:dd/MM/yyyy} não é um util");