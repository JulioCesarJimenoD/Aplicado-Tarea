using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Semanales
    {
        public void Semanas()
        {
            int dias;
            Console.WriteLine("Ingrese el dia de la semana:");
            dias = int.Parse(Console.ReadLine());

            switch (dias)
            {
                case 1: Console.WriteLine("Es lunes");
                    break;
                case 2: Console.WriteLine("Es martes");
                    break;
                case 3: Console.WriteLine("Es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Es Jueves");
                    break;
                case 5: Console.WriteLine("Es Viernes");
                    break;
                case 6: Console.WriteLine("Es Sabado");
                    break;
                case 7: Console.WriteLine("Es Domingo");
                    break;

            }
        }
    }
}
