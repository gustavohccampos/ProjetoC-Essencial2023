Console.WriteLine("Operadores Aritmeticos");
Console.WriteLine("--------------- ");

Console.WriteLine("##Operadors Aritméticos ##\n");
Console.WriteLine("Informe o valor de x");

int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");

int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"Poténcia de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"Valor minimo entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"Valor maximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"Coseno de x = {Math.Cos(x)}");
Console.WriteLine($"Seno x = {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}");


//Console.WriteLine($"soma de x+y = {x + y}");
//Console.WriteLine($"subtração de x-y = {x - y}");
//Console.WriteLine($"multiplicando de x*y = {x * y}");
//double divisao = (double) x / y;
//Console.WriteLine($"divisão de x/y = {divisao}");
//Console.WriteLine($"módulo de x%y = {x % y}");
Console.ReadKey();