using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3._2
{
    class Persona
    {
        private string nombre;
        private string dni;
        private string telefono;
        private int sexo;
        private int edad;
       


        public Persona(string nombre, string dni, string telefono, int sexo)
        {

            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
            this.sexo = sexo;
        }
     

        public int pSexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string GetSexo()
        {
            switch (sexo)
            {
                case 1: return "Masculino";
                case 2: return "Femenino";
                case 3: return "otro";
                default: return "No se ha seleccionado sexo";
            }

        }

        public string pTelefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
           public int pEdad
        {
            get { return edad; }
            set { edad = value; }
        }


        public string pDni
        {
            get { return dni; }
            set { dni = value; }
        }


        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string tostring()
        {

            return "|Nombre: " + nombre + "|Dni:" + dni + "|Telefono:" + telefono + "Sexo" + GetSexo();
        }

    }
}
