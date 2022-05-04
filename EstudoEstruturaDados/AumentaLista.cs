using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEstruturaDados
{
    public class AumentaLista
    {
        public static T[] ReajustarLista<T>(T[] arr, int valor)
        {
            T[] temp = new T[valor];
            for (var i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }
    }
}
