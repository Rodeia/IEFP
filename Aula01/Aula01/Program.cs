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
            long com = aleatorio.Next(1, 1000);
            long pontos = 1000;
            long tentativas = 10;
            long maxima = 1000;
            long minima = 1;
            long user = 0;
            bool aux = false;
            Console.WriteLine("O computador escolheu um numero aleatório entre {0} e {1}, qual acha que é?", minima, maxima);
            Console.WriteLine();
        Start:
            if (tentativas > 0)
            {
                do
                {
                    do
                    {
                        if (aux == true)
                        {
                            Console.WriteLine("Numero invalido! insere um numero entre 1 e 1000");
                            Console.WriteLine("");
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
                        goto Start;
                    }
                        aux = true;
                    } while (user <0 || user > 1000);
                    aux = false;
                    if (user == com)
                    {
                        if (tentativas == 10)
                        {
                            Console.WriteLine("Ganhaste logo há primeira!!!");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Ganhaste Com {0} pontos e {1} tentativas restantes!", pontos, tentativas);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        if (user > com)
                        {
                            if (user < maxima)
                            {
                                maxima = user;
                            }
                            tentativas = tentativas - 1;
                            pontos = pontos - 100;
                            if (tentativas >= 1)
                            {
                                Console.WriteLine("O numero procurado é inferior!Tens {0} e {1} tentativas restantes.", pontos, tentativas);
                                Console.WriteLine("O numero que o computador escolheu está entre os números {0} e {1}", minima, maxima);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Perdeste , o numero certo era " + com);
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            if (user > minima)
                            {
                                minima = user;
                            }
                            tentativas = tentativas - 1;
                            pontos = pontos - 100;
                            if (tentativas >= 1)
                            {
                                Console.WriteLine("O numero procurado é maior!!!Tens {0} e {1} tentativas restantes.", pontos, tentativas);
                                Console.WriteLine("O numero que o computador escolheu está entre os números {0} e {1}", minima, maxima);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Perdeste , o numero certo era {0}", com);
                                Console.WriteLine();
                            }
                        }
                    }
                } while (tentativas > 0 || user != com);
            }
        }
    }
}
