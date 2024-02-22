// See https://aka.ms/new-console-template for more information
Console.WriteLine("Construtor");
Console.WriteLine("----------------\n");

//SO imprime o 0 por que o resto é null
Aluno aluno = new Aluno("teste",32,"Masculino","S");
//Aluno aluno = new Aluno();
Console.WriteLine(aluno.Nome);
Console.WriteLine(aluno.Idade);
Console.WriteLine(aluno.Sexo);
Console.WriteLine(aluno.Aprovado);

//Operador Ternario ( condição ? expressao_se_true:expressao_se_false)
Console.WriteLine(aluno.Nome==null?"null":aluno.Nome);
Console.WriteLine(aluno.Idade==0? "zero":aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo); ;
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);

//-------------------------------------------------
public class Aluno
{
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}