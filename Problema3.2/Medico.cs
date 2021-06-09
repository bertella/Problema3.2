using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3._2
{
    class Medico:Persona
    {
        private int especialidad;
        private double costo;



    public Medico(int especialidad, string nombre, string dni, string telefono, int sexo) 
           : base(nombre,dni,telefono,sexo ) 
        {
            this.especialidad = especialidad;
           
        }
        public string getEspecialidad()
        {
            switch (especialidad)
            {
                case 1: return "Traumatologia";
                case 2: return "Pediatria";
                case 3: return "Cardiologia";
                default: return "No se ha seleccionado sexo";
            }

        }
     

        public int pEspecialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
    }

     
}
