﻿using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizacion_Consola
{
    public class Program
    {
        static Montos montos = new Montos();
        static Clientes clientes = new Clientes();
        static Telefonia libreta = new Telefonia();
        static SalonClases salon = new SalonClases();
        static Diccionario diccionario = new Diccionario();
        static void Main(string[] args)
        {
            PromediarSalon();
            //Diccionario();
           // Diccionario();
            //LibreriaContacto();
            //EntradaClientes();
           // MontoDelMes();
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
            Console.WriteLine("INGRESE TODAS LAS  CALIFICACIONES");
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
            Console.WriteLine("La calificacion mayor es-------------------"+maximo);
            Console.WriteLine("La Calificacion menor es-------------------" + minimo);
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


            Console.WriteLine("Inserte Una palabra ya establesidas");
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
                Console.Write("Contactos Añadido: ");
               Console.WriteLine("Nombre: " +item.Nombre+"." +  " Telefono : " +item.Telefono);
                
            }


        }

        static void EntradaClientes()
        {
            clientes.Cliente.Enqueue("Randy");
            clientes.Cliente.Enqueue("Adonis");
            clientes.Cliente.Enqueue("Castillo");
            clientes.Cliente.Enqueue("Juste");
            clientes.Cliente.Enqueue("Jaquez");

            for (int a=0; clientes.Cliente.Count>0; a++ )
            {
                Console.WriteLine("Primero en llegar:" + clientes.Cliente.Peek());
                clientes.Cliente.Dequeue();
                Console.ReadLine();
                Console.WriteLine("Siguiente-----------");

            }
            Console.WriteLine("No hay mas clientes");
        }

        static void MontoDelMes()
        {
            montos.MontosES.Add(new Montos { Monto = 506, Fecha = "25/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 805, Fecha = "26/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 200, Fecha = "27/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 908, Fecha = "28/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 1512, Fecha = "29/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 587, Fecha = "30/1/2000" });

            //var desiente = montos.MontosES.OrderBy(x => x.Monto);
            var Sum = montos.MontosES.Sum(x => x.Monto);

            foreach (var item in montos.MontosES.OrderByDescending(x => x.Fecha))
            {
                Console.WriteLine(item.Fecha+ "--Gastos del Dia:" +item.Monto);
            }
            Console.Write("-------------------");
            Console.WriteLine("Total Mes: " + Sum);


        }


    
    }
}
