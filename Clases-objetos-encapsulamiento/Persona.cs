using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_objetos_encapsulamiento
{
    internal class Persona
    {

        //Persona: edad, sueldo, nombre.
        //Atributos
        private int edad;
        private float sueldo;
        private string nombre;


        // Setear en edad la edad:
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }


    }
}
