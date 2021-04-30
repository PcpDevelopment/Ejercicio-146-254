using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class Diccionario
    {

       public Dictionary<string, string> Elementos = new Dictionary<string, string>();

        public void ListaDeElementos(string a)
        {
            Elementos.Add("r", "carlos");
            Elementos.Add("Ropa", "Farlyn");
            Elementos.Add("Papel", "Edu");
            Elementos.Add("salida", "Cass"); 
            Elementos.Add("Estafa", "Edgar");
        }
    }
}
