// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operador Uniario Ternario");
Console.WriteLine("----------------------");

int positivo = 1;
int resultado;
resultado = +positivo;
Console.WriteLine(resultado);


Console.WriteLine("Informe o numero: \n");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O negativo de {n} é : {-n}");
Console.ReadKey();

var temp = Convert.ToDouble(Console.ReadLine());
var resulTemp = temp > 27 ? "Quente" : "Normal";
Console.WriteLine($"O tempo está: {resulTemp}");


Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());
string resultado1 = x > y ? "x é maior que y" :
                   x < y ? "x é menor que y" :
                   x == y ? "x é igual a y" : "Sem resultado";
Console.WriteLine(resultado1);

Console.ReadKey();
