using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAccesoDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>() { 0, 1, 6, 2, 13, 57, 43, 20, 31, 28, 10 };
            var pares = Ejercicio3.SecuenciaNumeros(lista);
            foreach (var p in pares)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
