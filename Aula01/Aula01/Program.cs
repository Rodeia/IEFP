using System;

namespace Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int com = aleatorio.Next(1, 1000);
            int pontos = 1000;
            int tentativas = 10;
            int maxima = 1000;
            int minima = 1;
            Console.WriteLine("O computador escolheu um numero aleatório entre "+ minima +" e "+ maxima + " qual acha que é?");
            Console.WriteLine();
            while (tentativas > 0)
            {
                int user = int.Parse(Console.ReadLine());
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
                        Console.WriteLine("Ganhaste Com " + pontos + " pontos e " + tentativas + " tentativas restantes!");
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
                            Console.WriteLine("O numero procurado é inferior!Tens " + pontos + " pontos " + "e " + tentativas + " tentativas restantes");
                            Console.WriteLine("O numero que o computador escolheu está entre os números "+ minima+ " e "+ maxima);
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
                            Console.WriteLine("O numero procurado é maior!!!Tens " + pontos + " pontos " + "e " + tentativas + " tentativas restantes");
                            Console.WriteLine("O numero que o computador escolheu está entre os números "+ minima+ " e "+ maxima);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Perdeste , o numero certo era "+ com);
                            Console.WriteLine();
                            Console.ReadLine();
                        }
                    }
                }
            }
        }
    }
}