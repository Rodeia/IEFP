using System;

namespace Aula02
{
    class MainClass
    {
        public static int Soma(int a, int b)
        {
            return a + b;
        }
        public static int Subtracao(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicacao(int a, int b)
        {
            return a * b;
        }
        public static double Divisao(double a, double b)
        {
            return a / b;
        }
        public static void Main (string[] args)
        {
            string repetir;
            do {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Clear();
                    Console.WriteLine ("\n1 - soma");
                    Console.WriteLine ("2 - Subtrção");
                    Console.WriteLine ("3 - Multiplicação");
                    Console.WriteLine ("4 - DIvisão");
                    int final = int.Parse (Console.ReadLine ());
                    Console.WriteLine ();
                    Console.WriteLine ("Insira o primeiro valor:");
                    int user0 = int.Parse (Console.ReadLine ());
                    Console.WriteLine ("Insira o Segundo valor:");
                    int user1 = int.Parse (Console.ReadLine ());

                    switch (final) 
                    {
                    case 1:
                        int a = Soma (user0, user1);
                        Console.WriteLine ("\nA soma de {0} e {1} é {2}.", user0, user1, a);
                        break;
                    case 2:
                        int b = Subtracao (user0, user1);
                        Console.WriteLine ("\nA subtração de {0} e {1} é {2}.", user0, user1, b);
                        break;
                    case 3:
                        int c = Multiplicacao (user0, user1);
                        Console.WriteLine ("\nA multiplicação de {0} e {1} é {2}.", user0, user1, c);
                        break;
                    case 4:
                    double d = Divisao (user0,user1);
                        Console.WriteLine ("\nA divisão de {0} e {1} é {2}.", user0, user1, d);
                        break;
                    default:
                        Console.WriteLine ("Numero não valido\n");
                    break;
                    }
                Console.WriteLine ("Deseja continuar?\n");
                Console.WriteLine ("1 - para continuar");
                Console.WriteLine ("Qualquer outra tecla para terminar");
                repetir = Console.ReadLine();
                Console.WriteLine ();
            } while (repetir == "1");
        }
    }
}