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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzarJuego_Click(object sender, EventArgs e)
        {
            //cuando toco el boton comenzar debo mostrar pantalla para crear campeones
            crearCampeones crearCampeones = new crearCampeones(this);

            crearCampeones.ShowDialog();
        }

        public void ComenzarJuego(modelo campeon)
        {
           
        }

    }
}
