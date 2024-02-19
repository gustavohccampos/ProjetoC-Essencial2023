// See https://aka.ms/new-console-template for more information
Console.WriteLine("Instrução IF");
Console.WriteLine("-------------");

Console.WriteLine("Cliente Especial (S/N)");
var resposta = Console.ReadLine();
if (resposta == "S")
{
 Console.WriteLine("Desconto de 10%");
}


Console.WriteLine("Cliente Especial (TRUE/FALSE)");
var resposta2 = Convert.ToBoolean(Console.ReadLine());
if (resposta2)
{
    Console.WriteLine("Desconto de 20%");
}

Console.WriteLine("Valor de X:");
var x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Valor de Y:");
var y = Convert.ToDouble(Console.ReadLine());

if (x > y) { Console.WriteLine("X maior que Y!"); }
if (x < y) { Console.WriteLine("X menor que Y!"); }
if (x == y) { Console.WriteLine("X igual a Y!"); }


Console.WriteLine("Fim!");
Console.ReadKey();
