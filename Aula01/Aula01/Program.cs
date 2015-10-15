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
            int pontos = 1000;
            int tentativas = 10;
            int maxima = 1000;
            int minima = 1;
            int user = 0;
            Console.WriteLine("O computador escolheu um numero aleatório entre {0} e {1}, qual acha que é?", minima, maxima);
            Console.WriteLine();
            while (tentativas > 0)
            {
                String userin = Console.ReadLine();
                try
                {
                    user = Convert.ToInt32(userin);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Isso não é um numero! Perdeste uma tentativa!");
                    Console.WriteLine("");
                }
                if (user == com)
                {
                    if (tentativas == 10)
                    {
                        Console.WriteLine("Ganhaste logo há primeira!!!");
                        tentativas = tentativas - 10;
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Ganhaste Com {0} pontos e {1} tentativas restantes!", pontos, tentativas);
                        tentativas = tentativas - 10;
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
                            Console.WriteLine("O numero procurado é inferior!Tens {0} e {1} tentativas restantes." , pontos, tentativas);
                            Console.WriteLine("O numero que o computador escolheu está entre os números {0} e {1}", minima, maxima);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Perdeste , o numero certo era "+ com);
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
                            Console.WriteLine("O numero procurado é maior!!!Tens {0} e {1} tentativas restantes." , pontos, tentativas);
                            Console.WriteLine("O numero que o computador escolheu está entre os números {0} e {1}", minima, maxima);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Perdeste , o numero certo era {0}", com);
                            Console.WriteLine();
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
