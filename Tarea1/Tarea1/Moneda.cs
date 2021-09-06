using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{

    /*
     * 5 Hacer un programa que transforme entre
        dólares y euros y que también pida el tipo
        de cambio del día.
     * */
    class Moneda
    {
        public void cambio()
        {
            float pdolar = 56.70f;
            float Valord;
            float rdolar;

            float peuro = 0.84f;
            float valore;
             float reuro;


            Console.WriteLine("Ingrese la cantidad de dolor que desea cambiar: ");
            Valord = Convert.ToInt32(Console.ReadLine());

            rdolar = peuro * Valord;
            Console.WriteLine("La cantidad en euro es: {0} ",rdolar);

            Console.WriteLine("Ingrese la cantidad de euro que desea cambiar: ");
            valore = Convert.ToInt32(Console.ReadLine());
            reuro = pdolar * valore;
            Console.WriteLine("La cantidad en dolar es: {0}", reuro);



        }
    }
}
