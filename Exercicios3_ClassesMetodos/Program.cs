// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System;

Console.WriteLine("Exercicios 4 - Classes/Metodos/Construtores");
Console.WriteLine("---------------------------------------------\n");

//Exercício Prático
//1- Em um projeto console crie uma classe Carro contendo os atributos : modelo, montadora, marca, ano e
//potencia com os tipos de dados string, string, string, int e int.
//Crie também o comportamento Acelerar que não retorna nada e apenas exiba a mensagem “Acelerando...”
//c- Exiba os valores dos atributos no console para cada um dos objetos criados e chame o método Acelerar
//para cada objeto
//a- Crie um objeto chevrolet e atribua os seguintes valores aos atributos : Sedan, Chevrolet, Onix, 2016, 110
//d- Altere o método Acelerar para receber um parâmetro do tipo string chamado marca e a seguir altere a
//mensagem para exibir o texto “Acelerando o meu {marca}“ , seguido da marca do carro.
//b- Crie outro objeto ford e atribua os seguintes valores aos atributos: SUV, Ford, EcoSport, 2018, 120
//e- Crie um construtor na classe Carro que vai permitir criar objetos inicializando os valores dos atributos :
//modelo, montadora, marco, ano e potencia (use a palavra this para identificar a instância da classe)
//f- Crie novamente os objetos carro1 e carro2 com os mesmos valores usando o construtor acima e invoque o
//método Acelerar passando o valor do argumento para o parâmetro no método Acelerar
//Obs- Utilize a nomenclatura Pascal Case para definir os nomes e o modificador de acesso public para todos os
//membros da classe


Carro chevrolet = new();
chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2016;
chevrolet.Potencia = 110;
Console.WriteLine($"Modelo:{chevrolet.Modelo}\n Montadora:{chevrolet.Montadora} \n" +
    $"Marca:{chevrolet.Marca}\n Ano:{chevrolet.Ano}\n Potencia:{chevrolet.Potencia} CV");
chevrolet.Acelerar();
Console.WriteLine("----------------------------------");

Carro ford = new();
ford.Modelo = "SUV";
ford.Montadora = "Ford";
ford.Marca = "EcoSport";
ford.Ano = 2018;
ford.Potencia = 120;
Console.WriteLine($"Modelo:{ford.Modelo}\n Montadora:{ford.Montadora} \n" +
    $"Marca:{ford.Marca}\n Ano:{ford.Ano}\n Potencia:{ford.Potencia} CV");
ford.Acelerar();
Console.WriteLine("----------------------------------");

Console.ReadKey();



public class Carro {

    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public void Acelerar() 
    {
        Console.WriteLine("Acelerando...");
    }
}