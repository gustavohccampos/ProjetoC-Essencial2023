
Console.WriteLine("Tipos Nullable Types");
Console.WriteLine("---------------------------");

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

 int? i2 = null;
double?  d2 = null;
bool? b2 = null;

//Operador de coalicencia
int? a1 = 0;
int b1 = a1??0;

//Operador de Expressao
int? x = 0;
int? y = 3;
int? z = x * y;

//HasValue - Value
int? h = null;
if (h.HasValue)
{
    Console.WriteLine($"h = {h.Value}");
}
else {
    Console.WriteLine("h possui valor (null)");
}


Console.ReadLine();
