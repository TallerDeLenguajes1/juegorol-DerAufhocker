using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolkinen
{
    public partial class Form1 : Form
    {
        private string PlayerName1; //hago privada la funcion para acceder a ella desde un metodo
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            //creamos el formulario a cargar
            PlayerForm playerForm = new PlayerForm(this);
            //Mostramos el formulario emergente
            playerForm.ShowDialog();

        }

        public void comenzarJuego(string playerName1)
        {
            //asigno e nombr de los jugadores
            PlayerName1 = playerName1;

            //muestro los botones de juego y oculto el boton de comenzar jueo
            btnComenzar.Visible = false;
            btnAtaque.Visible = true;
        }
    }
}
