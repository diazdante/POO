using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_objetos_encapsulamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creamos un objeto persona

            Persona p1 = new Persona();
            p1.setEdad(20);

            Console.WriteLine("La edad de la persona es: " + p1.getEdad());
            Console.ReadKey();

            //creamos objeto botella

            Botella b1 = new Botella();
            b1.Capacidad = 200;
        }
    }
}
