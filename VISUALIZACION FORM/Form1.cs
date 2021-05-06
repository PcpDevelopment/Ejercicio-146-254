using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISUALIZACION_FORM
{
    
    public partial class Form1 : Form
    {
        static Montos montos = new Montos();
        static Clientes clientes = new Clientes();
        static Telefonia libreta = new Telefonia();
        static SalonClases salon = new SalonClases();
        static Diccionario diccionario = new Diccionario();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTCalcular_Click(object sender, EventArgs e)
        {
            
            
            //listBoxNotas.Items.Clear();
            //int numeros //= int.Parse(TxBNotas.Text);
            
            
            int numero = int.Parse(TxBNotas.Text);

            if (numero > 100 && numero < 70)
            {
                salon.EntradaNotas(numero);
                salon.nota.Add(numero);
                var EdadMaxima = salon.nota.Max();
                LbMayor.Text = EdadMaxima.ToString();
                var EdadMinima = salon.nota.Min();
                LbMenor.Text = EdadMinima.ToString();
                double Media = salon.nota.Average();
                LbPromedio.Text = Media.ToString();

                foreach (var item in salon.PromedioEstudiantes)
                {
                    listBoxNotas.Items.Add(numero);

                }
            }

            else
            {


                MessageBox.Show("Algo salio mal");

            }





            salon.PromedioEstudiantes.Clear();
            TxBNotas.Text = string.Empty;
            
            //listBoxNotas.Items.Clear();   
        }
        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            listBoxNotas.Items.Clear();
            LbMayor.Text = string.Empty;
            LbMenor.Text = string.Empty;
            LbPromedio.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string Nombres = txNombre.Text;
                string Numero = txTelefono.Text;                
                txNombre.Text = string.Empty;
                txTelefono.Text = string.Empty;
                libreta.Telefonias.Clear();

            if (string.IsNullOrWhiteSpace (Nombres) && string.IsNullOrWhiteSpace(Numero))
            {
                MessageBox.Show("algo salio mal");
            }
            else
            {
                libreta.Contactos(Nombres, Numero);

                foreach (var item in libreta.Telefonias)
                {
                    listBoxLibreta.Items.Add(item.Nombre+ item.Telefono);
                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
