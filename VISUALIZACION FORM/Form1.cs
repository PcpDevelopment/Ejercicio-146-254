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
        int cont = 0;
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

            if ((numero >70) && (numero<100))
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
                    listBoxLibreta.Items.Add(item.Nombre+" "+item.Telefono);
                }

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string nombre = TxCliente.Text;
            clientes.Cliente.Enqueue(nombre);

          
            cont++;
          
            


            foreach (var item in clientes.Cliente)
            {
                
                lixboxcliente.Items.Add("CLiente " +cont+ " --------" +item);
            }

            clientes.Cliente.Clear();
            TxCliente.Text = string.Empty;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Palabra = txPalabra.Text;
            diccionario.ListaDeElementos(Palabra);
            
            if (diccionario.Elementos.ContainsKey(Palabra))
            {
                var ar= (diccionario.Elementos[Palabra]);
                ar = listViewDIc.Items.ToString();
            }
            else
            {
                MessageBox.Show("No existe esta palabra");
            }

            txPalabra.Text = string.Empty;


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            montos.MontosES.Add(new Montos { Monto = 506, Fecha = "25/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 805, Fecha = "26/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 200, Fecha = "27/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 908, Fecha = "28/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 1512, Fecha = "29/1/2000" });
            montos.MontosES.Add(new Montos { Monto = 587, Fecha = "30/1/2000" });

            
        }

    }
}
