using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEstruturaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }

            Console.Write(" " + num);
            Console.WriteLine();

            int[] numAumentado = AumentaLista.ReajustarLista(num, num.Length + 5);

            for (int i = 0; i < numAumentado.Length; i++)
            {
                Console.Write(numAumentado[i] + " ");
            }

            Console.Write(" " + numAumentado);
            Console.WriteLine();

            Array.Resize(ref numAumentado, numAumentado.Length + 10);

            for (int i = 0; i < numAumentado.Length; i++)
            {
                Console.Write(numAumentado[i] + " ");
            }

            Console.Write(" " + numAumentado);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
