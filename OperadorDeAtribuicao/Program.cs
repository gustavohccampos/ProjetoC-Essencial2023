﻿Console.WriteLine("Operadores de Atribuicao");
Console.WriteLine("--------------- ");

//usando operadores atribuigdo com tipos numéricos
float x = 10;
x = 20;

Console.WriteLine($"Valor inicial de x ={x}");
Console.WriteLine($"x+=5 ==> {x += 5}");
Console.WriteLine($"x-=3 ==> {x -= 3}");
Console.WriteLine($"x*=4 ==> {x *= 4}");
Console.WriteLine($"x/=5 ==> {x /= 5}");
Console.WriteLine($"x%=5 ==> {x %= 5}");

string y = "123";

    Console.WriteLine($"Valor inicial de y = {y}"); 
    y += "456";
    Console.WriteLine($"y += \"456\" ==> {y}");