using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono telefono1 = new Telefono("J7","Samsung");
          

            telefono1.NumeroTelefonico = "1151639389";
            telefono1.CodigoOperador = 1;

            Console.WriteLine("Tengo un " + telefono1.Marca + " modelo " + telefono1.Modelo);
            Console.WriteLine("Mi numero de telefono es " + telefono1.NumeroTelefonico + " y el codigo de operador es " + telefono1.CodigoOperador);


            Console.WriteLine(telefono1.llamar());
            Console.WriteLine(telefono1.llamar("dante"));




            Console.ReadKey();
        }
    }
}
