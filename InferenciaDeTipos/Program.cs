using System;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Inferencia de Tipos");
Console.WriteLine("--------------- ");

var idade = 25; 
var nome = "Maria"; 
var salario = 2500.00m; 

Console.WriteLine($" {nome} tem {idade} anos e ganha {salario.ToString("c")}");
//var limitações
var salario = null;
var titulo;
var salario, imposto, total;

//não posso mudar o tipo apos inicializar |
var num = 10; 
num = num + 20;
num = "Teste";

var teste = new Teste();
teste.MeuMetodo();

class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}; 


