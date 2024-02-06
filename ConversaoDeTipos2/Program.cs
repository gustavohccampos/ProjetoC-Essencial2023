// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Conversão de Tipos");
Console.WriteLine("--------------");

int valorInt = 123;
double valorDouble = 12.45;
decimal valorDecimal = 12.45678m;

string s1 = valorInt.ToString();
string s2 = valorDouble.ToString();
string s3 = valorDecimal.ToString();

//CONVERT
Console.WriteLine("--------------");
int valorInt2 = 10;
double valorDouble2 = 5.35;
bool valorBool = true;
Console.WriteLine("");

Console.WriteLine(Convert.ToString(valorInt));
Console.WriteLine(Convert.ToDouble(valorInt));
Console.WriteLine(Convert.ToString(valorBool)); 
Console.WriteLine(Convert.ToInt32(valorDouble));
int varInt = 100000;
Console.WriteLine(Convert.ToByte(varInt));