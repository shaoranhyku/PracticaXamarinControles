using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaXamarinControles.resources
{
    public class Contacto
    {
        /*DECLARACION DE VARIABLES*/
        private string nombre, edad, dni;

        /*CONSTRUCTOR*/
        public Contacto(string nombre, string edad, string dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Edad
        {
            get
            {
                return edad;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }
        }

        override
        public string ToString()
        {
            return "Nombre: " + Nombre + " Edad: " + Edad + " DNI: " + Dni;
        }

    }
}
