using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Telefonia
    {
        public List<Telefonia> Telefonias = new List<Telefonia>();
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public void Contactos(string nom, string tel)
        {
            //Nombre = nom;
            //Telefono = tel;
            Telefonias.Add(new Telefonia() { Nombre = nom, Telefono = tel });
        }

        
    }
}
