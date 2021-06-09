using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3._2
{
    class Clinica
    {
        private Medico[] personal;
        private Paciente[] clientes;
        private int contador;
        public Clinica(int tamanio)
        {
            personal = new Medico[tamanio];
            clientes = new Paciente[tamanio];
            contador = 0;
        }

        public void agregarMedico(Medico oMedico)
        {
            if (contador < personal.Length)
            {
                personal[contador] = oMedico;
                contador++;
            }
        }

        public string mostrarMedicos()
        {
            string aux = "Listado: \n";

            for (int i = 0; i < personal.Length; i++)
            {
                aux += personal[i];

            }
            return aux;
        }
        public string tostring( )
        {
            return mostrarMedicos();
        }
    }
}