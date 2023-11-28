using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_objetos_encapsulamiento
{
    internal class Botella
    { 



        //Botella: capacidad, color, material.
        private int capacidad;
        private string color;

        //Propiedad C# FORMA CORTA
        public string Material { get; set; }

        //Propiedad C#

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }


    }
}
