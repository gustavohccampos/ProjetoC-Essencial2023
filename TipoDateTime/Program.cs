
Console.WriteLine("Tipo DateTime");
Console.WriteLine("---------------------------");

//Cria data Atual do computador
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

//Criar uma data especifica usa o formato: aaaa,mm,dd
DateTime dataHoje = new DateTime(2024, 02, 03);
Console.WriteLine(dataHoje);

//definir Horas
DateTime dataHoraHoje = new DateTime(2024, 02, 03,23,30,25);
Console.WriteLine(dataHoraHoje);

Console.WriteLine("-------------");

//extrair informação da data atual
DateTime hoje = DateTime.Now;
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);

//Adicionar Valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(3));
Console.WriteLine(hoje.AddHours(1));

Console.WriteLine("-------------");
//Obter o Dia da Semana e do Ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

//Data Formato Longo e Curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());


Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());



Console.ReadLine();
