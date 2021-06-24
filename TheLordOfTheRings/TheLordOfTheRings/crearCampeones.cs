using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLordOfTheRings.entidades;

namespace TheLordOfTheRings
{
    public partial class crearCampeones : Form
    {
        //public Form1 llamada;
        public modelo Campeon1;

        public crearCampeones(Form1 llamadaAlFormulario)
        {
            InitializeComponent();
            //llamada = llamadaAlFormulario;
        }

        private void crearCampeones_Load(object sender, EventArgs e)
        {

        }

        private void crearEquipo_Click(object sender, EventArgs e)
        {
            //creamos nuestro primer campeon
            //obtengo los datos del formulario
            string nombreCampeon1 = txtNombreCampeon1.Text;
            string ApodoCampeon1 = txtApodoCampeon1.Text;
            DateTime NacimientoCampeon1 = Convert.ToDateTime(txtFechaNacCamp1.Text);
            string especie = txtCampeon1.Text;
            TipoEspecie especie1;

            if (especie.Equals(TipoEspecie.Humano.ToString()))
            {
                especie1 = TipoEspecie.Humano;
            }
            if (especie.Equals(TipoEspecie.Elfo.ToString()))
            {
                especie1 = TipoEspecie.Elfo;
            }
            else
            {
                especie1 = TipoEspecie.Enano;
            }

            //paso los datos a un modelo de personaje

            modelo personaje = new modelo(especie1,nombreCampeon1,ApodoCampeon1,NacimientoCampeon1);

            //TipoEspecie especie1;

            /*
            if (especie.Equals(TipoEspecie.Humano.ToString()))
            {
                especie1 = TipoEspecie.Humano;
                Humano Campeon1 = new Humano(especie1, nombreCampeon1, ApodoCampeon1, NacimientoCampeon1);
            }
            else if (especie.Equals(TipoEspecie.Elfo.ToString()))
            {
                especie1 = TipoEspecie.Elfo;
                Elfo Campeon1 = new Elfo(especie1, nombreCampeon1, ApodoCampeon1, NacimientoCampeon1);
            }
            else
            {
                especie1 = TipoEspecie.Enano;
                Enano Campeon1 = new Enano(especie1, nombreCampeon1, ApodoCampeon1, NacimientoCampeon1);
            }
            */
        }
    }
}
