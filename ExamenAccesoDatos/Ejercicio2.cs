using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAccesoDatos
{
    class Ejercicio2
    {
        public void linq()
        {
            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 1, 2 };

            var array = a.Except(b);

        }
    }
}
