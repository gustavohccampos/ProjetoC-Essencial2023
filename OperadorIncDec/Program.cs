Console.WriteLine("Operadores de Incremento e Decremento");
Console.WriteLine("--------------- ");

int x = 0;

Console.WriteLine($"x = {x}");

//pés-decremento —> primeiro resolve depois decrementa
int resultado1 = x-- + 10;
Console.WriteLine($"pés-decremento = {resultado1}");
Console.WriteLine($"valor de x => {x}\n");
//pré-decremento —> primeiro decrementa depois resolve
int y = 0;

Console.WriteLine($"y = {y}");
int resultado2 = --y + 10;

Console.WriteLine($"pré-decremento => {resultado2}");
Console.WriteLine($"valor de y = {y}\n");
Console.ReadKey();