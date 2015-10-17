using System;
using System.IO;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Random aleatorio = new Random();
            int com = aleatorio.Next(1, 1000);
            Console.WriteLine(com);
            int pontos = 1000;
            int tentativas = 10;
            long maxima = 1000;
            long minima = 1;
            long user = 0;
            bool aux = false;
            Console.WriteLine("O computador escolheu um numero aleatório entre {0} e {1}, qual acha que é?", minima, maxima);
            Console.WriteLine();
            Console.Write("#Aposta> ");
        Start:
            if (tentativas > 0)
            {
                do
                {
                    do
                    {
                        if (aux == true)
                        {
                            Console.WriteLine("Numero invalido! Tem de ser um numero entre 1 e 1000");
                            Console.WriteLine();
                            Console.Write("#Aposta> ");
                        }
                    String userin = Console.ReadLine();
                    try
                    {
                            user = long.Parse(userin); 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Isso não é um numero!");
                        Console.WriteLine();
                        aux = false;
                        Console.Write("#Aposta> ");
                        goto Start;
                    }
                        aux = true;
                    } while (user < 0 || user > 1000);
                    aux = false;
                    if (user == com && tentativas == 10)
                    {
                            Console.WriteLine("Ganhaste logo há primeira!!!");
                            Console.WriteLine();
                            Console.Write("Carrega ENTER para terminar o jogo.");
                            Console.ReadKey();
                    }
                    else if (user == com)
                    {
                        Console.WriteLine("Ganhaste Com {0} pontos e {1} tentativas restantes!", pontos, tentativas);
                        Console.WriteLine();
                        Console.Write("Carrega ENTER para terminar o jogo.");
                        Console.ReadKey();
                    }
                    else
                    {
                        if (user > com)
                        {
                            tentativas = tentativas - 1;
                            pontos = pontos - 100;
                            if (user < maxima)
                            {
                                maxima = user;
                            }
                            if (tentativas > 0)
                            {
                                if (user > maxima)
                                {
                                    Console.WriteLine("ATENÇÃO: O numero inserido é maior que a máxima {0}!", maxima);
                                    Console.WriteLine("Procura entre {0} e {1}", minima, maxima);
                                    Console.WriteLine();
                                    tentativas = tentativas + 1;
                                    pontos = pontos + 100;
                                    Console.Write("#Aposta> ");
                                }
                                else
                                {
                                    Console.WriteLine("O numero procurado é inferior!");
                                    Console.WriteLine("Tens {0} pontos e {1} tentativas restantes.", pontos, tentativas);
                                    Console.WriteLine("Procura entre {0} e {1}", minima, maxima);
                                    Console.WriteLine();
                                    Console.Write("#Aposta> ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Perdeste , o numero certo era " + com);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            tentativas = tentativas - 1;
                            pontos = pontos - 100;
                            if (user > minima)
                            {
                                minima = user;
                            }
                            if (tentativas > 0)
                            {
                                if (user < minima)
                                {
                                    Console.WriteLine("ATENÇÃO: O numero inserido é menor que a mínima {0}!", minima);
                                    Console.WriteLine("Procura entre {0} e {1}", minima, maxima);
                                    Console.WriteLine();
                                    tentativas = tentativas + 1;
                                    pontos = pontos + 100;
                                    Console.Write("#Aposta> ");
                                }
                                else
                                {
                                    Console.WriteLine("O numero procurado é maior!");
                                    Console.WriteLine("Tens {0} pontos e {1} tentativas restantes.", pontos, tentativas);
                                    Console.WriteLine("Procura entre {0} e {1}", minima, maxima);
                                    Console.WriteLine();
                                    Console.Write("#Aposta> ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Perdeste , o numero certo era {0}", com);
                                Console.WriteLine();
                                Console.Write("Carrega ENTER para terminar o jogo.");
                                Console.ReadKey();
                            }
                        }
                    }
                } while (user != com || tentativas < 0);
            }
        }
    }
}
