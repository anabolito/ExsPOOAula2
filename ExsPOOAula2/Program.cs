using System.Xml.Linq;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int ex;
        do
        {
            Console.Clear();
            Console.WriteLine("EXERCÍCIOS: \n (1)-média de idades \n (2)-pi \n (3)-pt 2 do pi \n (4)-Bháskara\n (5)- Saque \n (6)- Situação saldo \n (7)- Laço de Repetição for \n (8)-Sair");
            Console.Write("Escolha um exercício para executar: ");
            ex = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (ex)
            {
                case 1:
                    int ageDuda = 20, ageBerreca = 22, ageHelo = 24;
                    double meanAges = (ageDuda + ageBerreca + ageHelo) / 3;
                    Console.WriteLine("------EXERCÍCIO 1 --------");
                    Console.WriteLine("\n    Média Idades");
                    Console.WriteLine("----------------------------\n\n");
                    Console.WriteLine($"Duda tem {ageDuda} anos\nBerreca tem {ageBerreca} anos\nHelô tem {ageHelo} anos\n A média de suas idades é de {meanAges}");
                    Console.WriteLine("Aperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("------EXERCÍCIO 2 --------");
                    Console.WriteLine("\n    Exercício do pi");
                    Console.WriteLine("----------------------------\n\n");
                    Console.WriteLine("O que acontece com o código abaixo?\nint pi = 3.14;");
                    Console.WriteLine("\n\n R: Código não compila. Mensagem de erro dizendo que não é possível converter um tipo double em int");
                    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("------EXERCÍCIO 3 --------");
                    Console.WriteLine("\n  Exercício do pi parte II ");
                    Console.WriteLine("----------------------------\n\n");
                    double pi = 3.14; int piParteInteira = (int)pi; Console.WriteLine("piParteInteira = " + piParteInteira);
                    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();

                    break;

                case 4:
                    Console.WriteLine("------EXERCÍCIO 4 --------");
                    Console.WriteLine("\n    Bháskara");
                    Console.WriteLine("---------------------------\n\n");

                    Console.Write("a = ");
                    double a = int.Parse(Console.ReadLine());
                    Console.Write("b = ");
                    double b = int.Parse(Console.ReadLine());
                    Console.Write("c = ");
                    double c = int.Parse(Console.ReadLine());

                    double delta = b * b + (-4 * a * c);
                    double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    if (delta >= 0)
                    {
                        Console.WriteLine($"Aplicando Bháskara aos valores informados, a primeira raiz da equação de segundo grau é {a1} e a segunda raiz é {a2}");
                    }
                    else
                    {
                        Console.WriteLine($" Com os valores informados, delta = {delta}, ou seja, negativo e não poderão ser retiradas as raízes da equação.");
                    }

                    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("------EXERCÍCIO 5 --------");
                    Console.WriteLine("\n          Saldo ");
                    Console.WriteLine("---------------------------\n\n");
                    double saldo = 100.0;
                    double valorSaque = 10.0;
                    if (saldo >= valorSaque)
                    {
                        saldo -= valorSaque;
                        Console.WriteLine($"Saque realizado com sucesso. Saldo = {saldo}");
                    }
                    else
                    {
                        Console.WriteLine($"Saldo Insuficiente. Saldo = {saldo}");
                    }
                    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();

                    break;

                case 6:
                    Console.WriteLine("------EXERCÍCIO 6 --------");
                    Console.WriteLine("\n    Situação de saldo");
                    Console.WriteLine("---------------------------\n\n");

                    Console.Write("Seu saldo: ");
                    double saldoX = double.Parse(Console.ReadLine());
                    if (saldoX < 0)
                        Console.WriteLine("Você está no vermelho.");
                    else
                    {
                        if (saldoX < 1000000)
                        {
                            Console.WriteLine("Você está no azul.");
                        }
                        else
                            Console.WriteLine("Você está bem demais!");
                    }



                    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();

                    break;

                case 7:
                    Console.WriteLine("------EXERCÍCIO 7 --------");
                    Console.WriteLine("\n    Realizando sua apresentação");
                    Console.WriteLine("---------------------------\n\n");

                    int valor = 2, potencia = 4, resultado = valor; 
                    for (int i = 1; i < potencia; i++) 
                    { 
                        resultado = resultado * valor; 
                    }
                    Console.WriteLine($"2 elevado à 4 = {resultado}");
                    Console.WriteLine("\nAperte qualquer tecla para retornar ao menu.");
                    Console.ReadKey();
                    break;

                case 8:
                    Console.WriteLine(" Até mais :)");
                    break;

                default:
                    Console.WriteLine("Escolha um exercício existente.");
                    Console.ReadKey();
                    break;
            }
        } while (ex != 4);
    }
}