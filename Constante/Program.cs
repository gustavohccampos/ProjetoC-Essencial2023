﻿Console.WriteLine("Constantes");
Console.WriteLine("--------------- ");
const int ANO = 12;
const int MES = 30, SEMANA = 7, QUINZENA = 15;
const int MESES_ANO = 12;
const int DIAS_ANO = 365;
const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;
Console.WriteLine(DIAS_POR_MES); 
Console.ReadKey();


double raio, perimetro, area;
const double PI = 3.14;
Console.WriteLine("Informe o raio do circulo"); 
raio = Convert.ToDouble(Console.ReadLine());
perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio, 2);
Console.WriteLine($"Perinetro = {perimetro}"); 
Console.WriteLine($"Area = {area}");

Console.ReadKey();