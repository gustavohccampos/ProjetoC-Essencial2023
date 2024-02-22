// See https://aka.ms/new-console-template for more information
Console.WriteLine("Construtor2");
Console.WriteLine("------------------\n");

Aluno aluno = new Aluno("teste");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade == 0 ? "zero" : aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo); ;
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

Console.WriteLine("----------------------------------------");

Aluno aluno2 = new Aluno(22,"M","S");
Console.WriteLine(aluno2.Nome == null ? "null" : aluno2.Nome);
Console.WriteLine(aluno2.Idade == 0 ? "zero" : aluno2.Idade);
Console.WriteLine(aluno2.Sexo == null ? "null" : aluno2.Sexo); ;
Console.WriteLine(aluno2.Aprovado == null ? "null" : aluno2.Aprovado);

Console.WriteLine("----------------------------------------");

Aluno aluno3 = new Aluno("Teste3",33, "F", "R");
Console.WriteLine(aluno3.Nome == null ? "null" : aluno3.Nome);
Console.WriteLine(aluno3.Idade == 0 ? "zero" : aluno3.Idade);
Console.WriteLine(aluno3.Sexo == null ? "null" : aluno3.Sexo); ;
Console.WriteLine(aluno3.Aprovado == null ? "null" : aluno3.Aprovado);



Console.ReadLine();

public class Aluno
{
 
    public Aluno(string nome)
    {
        Nome = nome;
    }

    public Aluno(int idade,string sexo,string aprovado)
    {
        Idade = idade;
        Sexo = sexo;    
        Aprovado = aprovado;
    }
    public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }


    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

