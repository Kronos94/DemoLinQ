using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinQ.Code
{
   public class Contacto
    {
        /*DECLARACION DE VARIABLES*/
        private string nombre, dni;

        private int edad;

        public Contacto()
        {

        }

        /*CONSTRUCTOR*/
        public Contacto(string nombre, string edad, string dni)
        {
            this.nombre = nombre;
            this.edad = int.Parse(edad);
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public int Edad
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
    }
}
