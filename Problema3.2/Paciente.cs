using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3._2
{
    class Paciente: Persona
    { 

        private int obraSocial;

        private string  historia;



        public Paciente(int obrasocial, string historia, string nombre, string dni, string telefono, int sexo)
               : base( nombre, dni , telefono,sexo)
        {
            {
                this.obraSocial = obraSocial;
                this.historia = historia;

            }
        }
 

        public string pHistoria
        {
            get { return historia; }
            set { historia = value; }
        }

        public int pObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }
        public string getObraSoc()
        {
            switch (obraSocial)
            {
                
                case 1: return "Apross";
                case 2: return "Met ";
                case 3: return "Osde";
                case 4: return "Otras";
                default: return "No se ha seleccionado prestador";
            }

        }
        

    }
    }
