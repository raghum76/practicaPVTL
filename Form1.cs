using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevadroClases
{
    public partial class Form1 : Form
    {
        Elevador mielev = new Elevador(6);
        ElevadorLujo elevLujo = new ElevadorLujo(5);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Liebre l1 = new Liebre(10);
            int g = l1.Posicion;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            mielev.AbrirPuerta();
            label1.Text  = mielev.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            mielev.CerrarPuerta();
            label1.Text = mielev.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            int piso=3;
            Button llamador;
            llamador = (Button) sender;
            piso = Convert.ToInt32 (llamador.Text);
            mielev.irA(piso);
            

            mielev.irA(Convert.ToInt32(((Button)sender).Text));

            label1.Text = mielev.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mielev.irA(5);
            label1.Text = mielev.ToString();
        }

    }
}
