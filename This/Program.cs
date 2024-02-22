// See https://aka.ms/new-console-template for more information
Console.WriteLine("This");
Console.WriteLine("------------------\n");

Teste t1 = new Teste();
t1.Num1 = 10;
t1.Num2= 20;
t1.Exibir();
Console.WriteLine("----------------------------------------");
Teste t2 = new Teste();
t2.Num1 = 30;
t2.Num2 = 40;
t2.Exibir();

Console.WriteLine("----------------------------------------");

Teste2 teste2 = new Teste2(999);



Console.ReadLine();



public class Teste2
{
    public int Num1;
    public int Num2;

    public Teste2(int num1, int num2)
    {
        Console.WriteLine($"\n Construtor com dois parâmetros {num1} e {num2} .");
    }
    public Teste2(int num): this(777,888)
    {
        Console.WriteLine($"\n Construtor com um parâmetros {num} .");
    }
}

    public class Teste 
{
    public int Num1;
    public int Num2;


    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\n this = {this}");
        Console.WriteLine("Num1:" + t.Num1);
        Console.WriteLine("Num2:" + t.Num2);
    }

    public void Exibir()
    {
        PassarParametro(this);
    }
}



public class Cliente
{
    public string? Nome;
    public int Idade;

    public Cliente(string? Nome,int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }
}

