using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizacion_Consola
{
    public class Program
    {

        
        static SalonClases salon = new SalonClases();
        static void Main(string[] args)
        {
            PromediarSalon();
            
        }
        static void PromediarSalon()
        {
            //List<double> nota = new List<double>();
            Console.WriteLine("INGRESE LA CANTIDAD DE CALIFICACIONES");
           double Notas = 0.0f;
            for(int a=1; a<5; a++ )
            { 
                Notas = double.Parse(Console.ReadLine());
                salon.EntradaNotas(Notas);
                Notas = Notas++;
                //nota.Add(Notas);
            }
            var media = salon.PromedioEstudiantes.Count;


            Console.WriteLine(Notas);




            Console.WriteLine("CANTIDAD DE CALIFICACIONES");
            foreach (var item in salon.PromedioEstudiantes)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
