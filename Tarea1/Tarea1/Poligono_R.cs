using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Poligono_R
    {
        public void Poligono()
        {
            int lado;
            Console.WriteLine("Ingrese el lado del poligono:");
            lado = int.Parse(Console.ReadLine());

            Console.WriteLine("El perimetro de un poligono de 5 lado es:" + lado *5);
        }

        
    }
}
