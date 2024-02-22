// See https://aka.ms/new-console-template for more information
Console.WriteLine("Classes e Metodos");
Console.WriteLine("---------------------\n");

Pessoa p1 = new();
p1.nome = "Maria";
p1.idade = 25;
p1.sexo = "feminino";
Console.WriteLine($"{p1.nome} {p1.idade} {p1.sexo}");

Pessoa p2 = new();
p2.nome = "marcos";
p2.idade = 23;
p2.sexo = "masculino";
Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

Pessoa p3 = p2;

Console.WriteLine($"{p3.nome} {p3.idade} {p3.sexo}");

//var p4 = new Pessoa();
//Pessoa p4 = new();
//Pessoa p4 = new Pessoa();


Console.ReadKey();

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;
}