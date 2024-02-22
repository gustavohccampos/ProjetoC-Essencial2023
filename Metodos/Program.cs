// See https://aka.ms/new-console-template for more information
Console.WriteLine("Metodos");
Console.WriteLine("---------------------\n");

MinhaClasse minhaClasse = new();
minhaClasse.Saudacao();
minhaClasse.ExibirData();

class MinhaClasse {
    public void Saudacao() 
    {
        Console.WriteLine("Bem-Vindo");
        Console.WriteLine("Hello World");
        ExibirData();
    }

    public void ExibirData() => 
        Console.WriteLine(DateTime.Now.ToShortDateString());
    //com uma instrução => substitui a {}

}
