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

        static Telefonia libreta = new Telefonia();
        static SalonClases salon = new SalonClases();
        static Diccionario diccionario = new Diccionario();
        static void Main(string[] args)
        {
            //PromediarSalon();
            //Diccionario();
            //Diccionario();
            LibreriaContacto();
        }
        static void PromediarArray()
        {
            int Notas = 0;
            double indice = 0.0f;
            double Promedio = 0.0f;
            double[] valor = {};
            double maximo = valor[0];
            double menor = valor[0];
            for (int a = 0; a < 5; a++)
            {
                Notas = int.Parse(Console.ReadLine());
                indice = indice + Notas;
                valor[a] = salon.EntradaNotas(Notas);
                
            }
            for (int i = 0; i < 5; i++)
            {
                if (valor[i] > maximo)
                {
                    maximo = valor[i];
                }
                if (valor[i] < menor)
                {
                    menor = valor[i];
                }
            }


            
            Console.WriteLine("El valor mayor es-------------------" + maximo);
            Console.WriteLine("El valor menor es-------------------" + menor);
            Console.WriteLine("El Promedio de Calificaciones------" + Promedio);

        }
        
        static void PromediarSalon()
        {
            List<double> nota = new List<double>();
            Console.WriteLine("INGRESE LA CANTIDAD DE CALIFICACIONES");
            double Notas = 0.0f;
            double indice = 0.0f;
            double Promedio = 0.0f;
            for(int a=0; a<5; a++ )
            { 
                Notas = double.Parse(Console.ReadLine());
                salon.EntradaNotas(Notas);
                indice = indice + Notas;
                nota.Add(Notas);
                
            }
            var media = salon.PromedioEstudiantes.Count;
            Promedio = indice / media;


            var maximo = nota.Max();
            var minimo = nota.Min();
            Console.WriteLine("El valor mayor es-------------------"+maximo);
            Console.WriteLine("El valor menor es-------------------" + minimo);
            Console.WriteLine("El Promedio de Calificaciones es------"+Promedio);

           // Console.WriteLine("CANTIDAD DE CALIFICACIONES");
           /* foreach (var item in salon.PromedioEstudiantes)
            {
                Console.WriteLine(item);
            }
            */
        }
        static void Diccionario()
        {
            Console.WriteLine("Inserte Una palabra");
            string ar = Console.ReadLine();
            diccionario.ListaDeElementos(ar);
            //Console.WriteLine(diccionario.Elementos[ar]);
            //string o = "";
            if(diccionario.Elementos.ContainsKey(ar))
            {
                Console.WriteLine(diccionario.Elementos[ar]);
            }
            else
            {
                Console.WriteLine("No esta");
            }
            
        }

        static void LibreriaContacto()
        {
            for(int a=0; a<2; a++)
            {
                Console.WriteLine("ingrese el nombre y numero del contacto");
                string nom = Console.ReadLine();
                string tel = Console.ReadLine();
                libreta.Contactos(nom, tel);

            }

            foreach (var item in libreta.Telefonias)
            {
               
               Console.WriteLine("Nombre: " +item.Nombre+  " Contacto: "+item.Telefono);
                
            }


        }
    }
}
