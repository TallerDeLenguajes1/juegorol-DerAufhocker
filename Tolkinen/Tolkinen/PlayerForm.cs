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
    public partial class PlayerForm : Form
    {
        private Form1 llamada;//esta variabe privada esta dentro de la clase PlayerForm por lo tanto podemos tener acceso a ella en cualquier funcion dentro de ella
        /// <summary>
        /// Este es el constructor donde inicializmos los companentes
        /// entonces puedo pasarle el Form1 para trabajar con él
        /// </summary>
        /// <param name="llamarForm1"></param>        
        public PlayerForm(Form1 llamarForm1)
        {
            InitializeComponent();
            // guardo la referencia de la variabe llamada
            llamada = llamarForm1;

            //crear evento de teclado para ingresar datos apretando enter
            namePlayer1.KeyDown += (sender, args) =>
            {
                //verifico si la tecla fue presionada
                if(args.KeyCode == Keys.Enter)
                {
                    btnPlayers.PerformClick();
                }
            };
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            //verificamos que se hayan ingresado los datos correctamente
            if (!string.IsNullOrEmpty(namePlayer1.Text))
            {
                //el campo nameplayer1 esta lleno entonces
                llamada.comenzarJuego(namePlayer1.Text.Trim());
                //cierro este formulario
                //this.Close();
            }
            else
            {
                //el campo nombr esta vacio
                label6.Visible = true;
            }

            //verificamos que se hayan ingresado los datos correctamente
            if (!string.IsNullOrEmpty(namePlayer2.Text))
            {
                //el campo nameplayer2 esta lleno entonces
                llamada.comenzarJuego(namePlayer2.Text.Trim());
                //cierro este formulario
                //this.Close();
            }
            else
            {
                //el campo nombr esta vacio
                label7.Visible = true;
            }

            //verificamos que se hayan ingresado los datos correctamente
            if (!string.IsNullOrEmpty(especiePlayer1.Text))
            {
                //el campo nameplayer1 esta lleno entonces
                llamada.comenzarJuego(especiePlayer1.Text.Trim());
                //cierro este formulario
                //this.Close();
            }
            else
            {
                //el campo nombr esta vacio
                label8.Visible = true;
            }

            //verificamos que se hayan ingresado los datos correctamente
            if (!string.IsNullOrEmpty(especiePlayer2.Text))
            {
                //el campo nameplayer1 esta lleno entonces
                llamada.comenzarJuego(especiePlayer2.Text.Trim());
                //cierro este formulario
                this.Close();
            }
            else
            {
                //el campo nombr esta vacio
                label9.Visible = true;
            }
            

            
        }
    }
}
