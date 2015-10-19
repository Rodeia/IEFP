using System;

namespace Aula02
{
    class MainClass
    {
        public static int Soma(int a, int b)
        {
            int soma = a + b;
            return soma;
        }
        public static int Subtracao(int a, int b)
        {
            int subtracao = a - b;
            return subtracao;
        }
        public static int Multiplicacao(int a, int b)
        {
            int multi = a * b;
            return multi;
        }
        public static double Divisao(double a, double b)
        {
            double div = a / b;
            return div;
        }
        public static void Main (string[] args)
        {
            string repetir = "null";
            do {
                    Console.WriteLine ();
                    Console.WriteLine ("Insira o primeiro valor:");
                    int user0 = int.Parse (Console.ReadLine ());
                    Console.WriteLine ("Insira o Segundo valor:");
                    int user1 = int.Parse (Console.ReadLine ());
                    Console.WriteLine ("1 - soma");
                    Console.WriteLine ("2 - Subtrção");
                    Console.WriteLine ("3 - Multiplicação");
                    Console.WriteLine ("4 - DIvisão");
                    int final = int.Parse (Console.ReadLine ());

                    switch (final) 
                    {
                    case 1:
                        int a = Soma (user0, user1);
                        Console.WriteLine ();
                        Console.WriteLine ("A soma de {0} e {1} é {2}.", user0, user1, a);
                        break;
                    case 2:
                        int b = Subtracao (user0, user1);
                        Console.WriteLine ();
                        Console.WriteLine ("A subtração de {0} e {1} é {2}.", user0, user1, b);
                        break;
                    case 3:
                        int c = Multiplicacao (user0, user1);
                        Console.WriteLine ();
                        Console.WriteLine ("A multiplicação de {0} e {1} é {2}.", user0, user1, c);
                        break;
                    case 4:
                    double d = Divisao (user0,user1);
                        Console.WriteLine ();
                        Console.WriteLine ("A divisão de {0} e {1} é {2}.", user0, user1, d);
                        break;
                    default:
                        Console.WriteLine ("Numero não valido");
                        Console.WriteLine ();
                    break;
                    }
                Console.WriteLine ("Deseja continuar?");
                Console.WriteLine ();
                Console.WriteLine ("1 - para continuar");
                Console.WriteLine ("Qualquer outra tecla para terminar");
                repetir = Console.ReadLine();
                Console.WriteLine ();
            } while (repetir == "1");
        }
    }
}