﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Estrutura de repetição com goto/label");
Console.WriteLine("--------------------\n");


int i = 1;

repetir:

Console.WriteLine($"i= {i}");

if (i <= 10)
    goto repetir;

Console.WriteLine("Fim do processamento...");

Console.ReadKey();
