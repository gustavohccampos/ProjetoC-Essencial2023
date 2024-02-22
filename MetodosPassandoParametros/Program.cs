// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metodos Passando Parametros");
Console.WriteLine("--------------------------\n");


var aluno = new Aluno();
aluno.Consultar();

Console.ReadLine();

//-------------------------------------------------
public class Aluno {

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;

    public void Consultar() {
        var aluno = new Aluno();

        Console.WriteLine("Digite o Nome do Aluno:");
        aluno.Nome = Console.ReadLine();

        Console.WriteLine("Digite a Idade do Aluno:");
        aluno.Idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o Sexo do Aluno:");
        aluno.Sexo = Console.ReadLine();

        Console.WriteLine("Digite se o Aluno foi Aprovado (S) ou (N):");
        aluno.Aprovado = Console.ReadLine();

        Curso curso = new Curso();
        curso.Resultado(aluno.Nome, aluno.Idade, aluno.Sexo, aluno.Aprovado);

        curso.Resultado2(aluno);
    }
}
//-------------------------------------------------
public class Curso {

    public void Resultado(string nome, int idade, string sexo, string aprovado)
    {
        Console.WriteLine($"\n O Aluno {nome}, do sexo {sexo}, com {idade} anos de idade");
        if (aprovado == "S" || aprovado=="s")
        { Console.WriteLine("\n foi Aprovado!"); }
        else { Console.WriteLine("\n foi Reprovado!"); }
  
    }

    public void Resultado2(Aluno aluno)
    {
        Console.WriteLine($"\nResultado2 \n O Aluno {aluno.Nome}, do sexo {aluno.Sexo}, com {aluno.Idade} anos de idade");
        if (aluno.Aprovado == "S" || aluno.Aprovado == "s")
        { Console.WriteLine("\n foi Aprovado!"); }
        else { Console.WriteLine("\n foi Reprovado!"); }

    }
}
