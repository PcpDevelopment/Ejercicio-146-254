using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class SalonClases
    {
        int valor;
      public  ArrayList PromedioEstudiantes = new ArrayList(10);
        public double Media{ get; set; }

        public void EntradaNotas(double notas)
        {
            double numeros = notas;
            PromedioEstudiantes.Add(numeros);

            
        }
        


    }
}
