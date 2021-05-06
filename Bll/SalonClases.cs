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
        
        public ArrayList  PromedioEstudiantes = new ArrayList();
       public List<double> nota = new List<double>();
        public double EntradaNotas(double notas)
        {
            
            double numeros = notas;
            PromedioEstudiantes.Add(numeros);

            return numeros;
            //valores[] = PromedioEstudiantes.Add(numeros);
        }
        public void EntradaNotas2(double notas)
        {
            double numeros = notas;
            nota.Add(numeros);


            
            
            
        }
        



    }
}
