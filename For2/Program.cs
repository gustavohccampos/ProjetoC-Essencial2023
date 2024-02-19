Console.WriteLine("Instrução For2");
Console.WriteLine("--------------------\n");

//-----------------------------------------------------
// multiplas expressões na inicialização e iteração
//-----------------------------------------------------

Console.WriteLine("## Loop For ##\n");

for (int k = 0, l = 0; k + l <= 20; k++, l++)
{
    Console.WriteLine($"i= {k} e i={l}");
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

//------------------------
// loop for seções opcionais
//-------------------------

int i = 1;
for (; i <= 10;)
{
    Console.WriteLine($"i= {i}");
    i++;
}
Console.ReadKey();


//--------------------
// loop infinito
//--------------------
int j = 1;
for (; ; )
{
    Console.WriteLine($"j = {j}");
    j++;
}
Console.ReadKey();

//------------------------
// loop for aninhado
//-------------------------

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y}) ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
