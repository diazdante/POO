using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_y_destructores
{
    internal class Botella
    {
        //Constructor

        public Botella(string color, string material)
        {
            this.color = color; //this es un puntero que hace referencia a la clase
            this.Material = material;
        }

        //Sobrecarga constructor (crear mismo constructor pero con otros parametros)

        public Botella() { }

        //Botella: capacidad, color, material.
        private int capacidad;
        private string color;
        public string Material { get; set; }

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
    }
}
