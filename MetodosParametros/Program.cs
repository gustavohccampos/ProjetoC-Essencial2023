// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metodos Parametros");
Console.WriteLine("--------------------\n");

MetodosParametros metodosParametros = new MetodosParametros();
metodosParametros.Saudacao("Teste",DateTime.Now.ToShortDateString());


var nomeCliente = "Cliente1";
var dataCliente = DateTime.Now.ToShortDateString();

MetodosParametros metodosParametros2 = new MetodosParametros();
metodosParametros.Saudacao(nomeCliente, dataCliente);

Console.ReadLine();


public class MetodosParametros
{

    public void Saudacao(string nome, string data)
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}