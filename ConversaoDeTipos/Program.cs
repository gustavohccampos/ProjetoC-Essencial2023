// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversão de Tipos");
Console.WriteLine( "--------------");

int varInt = 100;       //int usa 4 bits
double varDouble = varInt; //double usa 8 bits
Console.WriteLine(varDouble);


//Conversão implicita
int numeroInt = 2145678; 
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;
Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

//

double varDouble2 = 12.456; //8bytes
//int varInt2 = varDouble2; //4bytes
int varInt2 = (int)varDouble2;
Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;
float resultado = (float)num1 / num2; // 10/4 = 2.5
Console.WriteLine(resultado);