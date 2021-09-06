using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class ParOImpar
    {
        public void pares()
        {
            int valor;
            Console.WriteLine("Ingresa un numero: ");
            valor = int.Parse(Console.ReadLine());

            if ((valor % 2) == 0)
                Console.WriteLine("El numero es par");
            else
                Console.WriteLine("El numero es inpar");
        }
    }
}
