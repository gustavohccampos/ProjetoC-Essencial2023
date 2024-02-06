using Microsoft.VisualBasic;
using System;

Console.WriteLine("Exercicios 2");
Console.WriteLine("--------------- ");

//1- - Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5
//e exiba a saída no formato :Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação
//e a interpolação de strings.

string nome = "Paulo";
int idade = 17;
double nota = 7.5;
Console.WriteLine(nome + " tem " + idade + " anos e a nota " + nota);
Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota} usando concatenação.");

//2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
Console.WriteLine($"Aluno {nome} \ntem {idade} anos \nE nota {nota} usando concatenação.");

//5
Console.Write("letra1: ");
char letra1 = Convert.ToChar(Console.ReadLine());
Console.Write("letra2: ");
char letra2 = Convert.ToChar(Console.ReadLine());
Console.Write("letra3: ");
char letra3 = Convert.ToChar(Console.ReadLine());
Console.WriteLine($"{letra3} {letra2} {letra1}");


//7
Console.WriteLine("Informe o valor de x :");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o valor de y :");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Soma = {x + y}");
Console.WriteLine($"Subtração = {x - y}");
Console.WriteLine($"Multiplicação = {x * y}");
Console.WriteLine($"Divisão = {x / y}");
Console.WriteLine($"Módulo = {x % y}");
Console.WriteLine($"Exponenciação = {Math.Pow(x, y)}");

//8

int a = 1, b = 12, c = -13;
double delta, x1, x2;
Console.WriteLine("");

delta = Math.Pow(b, 2) - (4 * a * c);
x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
Console.WriteLine($"X¹={x1}");
x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);
Console.WriteLine($"X²={x2}");


//9
Console.Write("Nome: \t");
string nome9 = Console.ReadLine();
Console.Write("\nSenha: \t");
int senha9 = Convert.ToInt32(Console.ReadLine());
var resultado9 = (nome9 == "admin" || nome9 == "maria") 
    && senha9 == 123 ? "Login feito com sucesso" : "Login inválido";
Console.WriteLine(resultado9);

//11 Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
//console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)

Console.Write("\nInforme o valor de x : \t");
int x11 = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de y : \t");
int y11 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(x11 % 2 == 0 ? "x é par " : "x não é par");
Console.WriteLine(y11 % 2 == 0 ? "y é par " : "y não é par");
Console.ReadKey();


//12 - 12- Crie um programa que receba um numero inteiro x via teclado e calcule e
//imprima no console o resultado das seguintes operações : (x ^ 2->x ao
//quadrado) (pi = 3.1415)
Console.Write("Informe o valor de x : \t");
int x12 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(-6 + x12 * 5);
Console.WriteLine((13 - 2) * x12);
Console.WriteLine((x12 + -2) * (20 / x12));
Console.WriteLine((12 + x12) / (x12 - 4));
double resultado12 = 3 * Math.Pow(x12, 2) + x12 + 10;
double area12 = Math.PI * Math.Pow(x12, 2);
Console.WriteLine(resultado12);
Console.WriteLine(area12);
Console.ReadKey();


//14 Escreva um programa que solicite a
//temperatura em graus Celsius e converta
//para Kelvin e Farhenheit usando as fórmulas a seguir:
//- Converter para Kelvin => K = C + 273 ;
//-Converter para Farhenheit => F = (C * 9) / 5 + 32;

Console.Write("Graus Celsius:");
double cel = Convert.ToDouble(Console.ReadLine());
double kel = cel + 273;
Console.WriteLine($"Kelvin = {kel}");
double far = (cel * 9) / 5 + 32;
Console.WriteLine($"Fahrenheit = {far}");
Console.ReadKey();



Console.ReadKey();


