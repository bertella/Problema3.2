using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema3._2
{
    public partial class Form1 : Form
    {
        Clinica clinica = new Clinica(1);
        Medico m1 = new Medico(1,"Carlos sasbagh ","3222112","85655211",1);
        Medico m2= new Medico(2, "Carlos sasbagh ", "3222112", "85655211", 2);
       
    
            
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clinica.mostrarMedicos(m1);


        }
    }
}
