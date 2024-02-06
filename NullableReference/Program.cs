// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nullable Reference");
Console.WriteLine("-----------------");

string nome = null;
Console.WriteLine( nome);

Console.WriteLine(nome.ToUpper());

string? nome2= null;
Console.WriteLine( nome2?.ToUpper());

string nome3 = "";
Console.WriteLine( nome3?.ToUpper());