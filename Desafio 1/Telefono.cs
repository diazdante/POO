using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        //ATRIBUTOS
        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        //PROPIEDADES
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (codigoOperador == 1 || codigoOperador == 2 || codigoOperador == 3)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }

        //CONSTRUCTOR
        public Telefono(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
        }

        //METODO

        public string llamar()
        {
            return "Realizando llamada..";
        }
        //SOBRECARGA
        public string llamar(string contacto)
        {
            return "Realizando llamada.. " + contacto;
        }

    }
}