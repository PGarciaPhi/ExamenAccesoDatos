using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAccesoDatos
{
    class Ejercicio3
    {
        public static IList<int> SecuenciaNumeros(IList<int> secuencia)
        {
            Console.WriteLine("Elige una opción: ");
            Console.WriteLine("1 - Pares.");
            Console.WriteLine("2 - Mayores que 10.");
            Console.WriteLine("3 - Menores que 10.");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    return Ejercicio3.Pares(secuencia);
                case "2":
                    return Ejercicio3.MayoresDiez(secuencia);
                case "3":
                    return Ejercicio3.MenoresDiez(secuencia);
                default:
                    Console.WriteLine("Opción incorrecta");
                    return null;
            }
        }
        private static IList<int> Pares(IList<int> secuencia)
        {
            List<int> lista = new List<int>();
            foreach(var s in secuencia)
            {
                if(s % 2 == 0)
                {
                    lista.Add(s);
                }
            }
            return lista;
        }
        private static IList<int> MayoresDiez(IList<int> secuencia)
        {
            List<int> lista = new List<int>();
            foreach (var s in secuencia)
            {
                if (s > 10)
                {
                    lista.Add(s);
                }
            }
            return lista;
        }
        private static IList<int> MenoresDiez(IList<int> secuencia)
        {
            List<int> lista = new List<int>();
            foreach (var s in secuencia)
            {
                if (s < 10)
                {
                    lista.Add(s);
                }
            }
            return lista;
        }
    }
}
