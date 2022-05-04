using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreAVL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello world");
            Console.WriteLine("Estudo de arvore AVL");

            Func<int, int> square = x => x * x; //Expressão lambda antes da seta é o parametro e depois da seta é o return
            square(5);

            Console.WriteLine(square(5));

            Console.ReadLine();
        }
    }
}
