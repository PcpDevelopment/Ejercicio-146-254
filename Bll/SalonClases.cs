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
        public double EntradaNotas(double notas)
        {
            
            double numeros = notas;
            PromedioEstudiantes.Add(numeros);

            return numeros;
            //valores[] = PromedioEstudiantes.Add(numeros);
        }
        /*public void EntradaNotas2(double notas)
        {
            double numeros = notas;
            for(int a=0; a>5; a++)
            {
                valores[a] = PromedioEstudiantes.Add(numeros);
            }
            
        }
        */



    }
}
