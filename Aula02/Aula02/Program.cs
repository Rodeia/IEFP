using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02 // Pasta do projeto
{
    class Program // Nome da folha
    {
        static void Soma(int a, int b) // Método criado por mim
        {
            int soma = a + b;
            Console.WriteLine("Soma: {0} ", soma);
        }
        static void Main(string[] args)  // Método que arranca os projetos
        {
         int x = 10;
         int y = 20;
            Soma(x,y);
            Soma(x + 5, x * y);
            Soma(x, 0);
        }
    }
}
