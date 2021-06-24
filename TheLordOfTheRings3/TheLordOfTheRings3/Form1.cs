using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLordOfTheRings3.clases;

namespace TheLordOfTheRings3
{
    public partial class Form1 : Form
    {
        List <modelo>listaJugadores = new List<modelo>();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnComenzarJuego_Click(object sender, EventArgs e)
        {
            //instancio el formulario donde voy a crear mis jugadores
            CrearPersonaje crearPersonaje = new CrearPersonaje();
            //creo mi jugador
            modelo jugador; 

            //desaparezco el boton de comezar juego y aparecen la pantalla y el boton de batalla
            btnComenzarJuego.Visible = false;
            pantalla.Visible = true;
            btnComenzarBatalla.Visible = true;

            //creo mi lista de personajes aleatorios
            for (int i = 0; i < crearPersonaje.listaNombres.Count; i++)
            {
                jugador = crearPersonaje.CrearPersonajeAletorio(i);
                listaJugadores.Add(jugador);
                pantalla.Items.Add(jugador.Nombre);
                //pantalla.Items.Add(modelo.mostrarPersonaje(jugador));
            }

            
        }

        private void btnComenzarBatalla_Click(object sender, EventArgs e)
        {
            FormBatalla formBatalla = new FormBatalla(listaJugadores);
            formBatalla.ShowDialog();
        }
    }
}
