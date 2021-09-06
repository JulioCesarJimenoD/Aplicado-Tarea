using System;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aqui el programa presenta mi nombre");
            mi_nombre name = new mi_nombre();
            name.nombre();

            Console.WriteLine("\nAqui el programa presenta un aviso");
            Aviso_p2 aviso = new Aviso_p2();
            aviso.Aviso();

            Console.WriteLine("\nAqui el programa presenta un poligono");
            Poligono_R p = new Poligono_R();
            p.Poligono();

            Console.WriteLine("\nAqui el programa presenta cambio de monedas");
            Moneda c = new Moneda();
            c.cambio();

            Console.WriteLine("\nAqui el programa presenta numeros pares");
            ParOImpar pa = new ParOImpar();
            pa.pares();

            Console.WriteLine("\nAqui el programa presenta los dias de las semanas");
            Semanales s = new Semanales();
            s.Semanas();

            Console.WriteLine("\n Hasta aqui es todos");
            Console.WriteLine("\n Julio Cesar Jimeno D. ");


            Console.ReadKey();
        }
    }
}
