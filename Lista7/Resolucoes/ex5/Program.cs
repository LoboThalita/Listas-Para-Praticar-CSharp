DateTime data1 = new(2001, 02, 24);
DateTime data2 = new(2023, 04, 05);

Console.WriteLine($"A diferença em dias das datas {data2:dd/MM/yyyy} e {data1:dd/MM/yyyy} é de " +(data2 - data1).ToString("dd"));

