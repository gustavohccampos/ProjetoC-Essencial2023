Console.WriteLine("Entrada de dados");
Console.WriteLine("--------------");
Console.WriteLine("\nInforme a seu nome:");
string nome = Console.ReadLine();
Console.WriteLine("\nInforme a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nO seu nome é {nome}");
Console.WriteLine($"\nA sua idade é {idade} anos");
Console.ReadKey();