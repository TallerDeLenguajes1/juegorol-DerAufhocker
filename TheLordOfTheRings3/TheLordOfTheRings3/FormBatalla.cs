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
    public partial class FormBatalla : Form
    {
        
        List<modelo> listaEliminados = new List<modelo>();
        List<modelo> listaJugadores = new List<modelo>();
        public FormBatalla(List<modelo> listaPersonajes)
        {
            InitializeComponent();
            MostrarListaCompetidores(listaPersonajes);
            listaJugadores = listaPersonajes;
        }

        private void MostrarListaCompetidores(List<modelo> listaPersonajes)
        {
            foreach (modelo personaje in listaPersonajes)
            {
                listaParticipantes.Items.Add(modelo.mostrarPersonaje(personaje));
            }
        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int aleatorio1, aleatorio2;
            do
            {
                aleatorio1 = rand.Next(0, listaJugadores.Count);
                aleatorio2 = rand.Next(0, listaJugadores.Count);
            } while (aleatorio1 == aleatorio2);

            MostrarListaCompetidores(listaJugadores[aleatorio1], listaJugadores[aleatorio2]);
            GenerarBatalla(listaEliminados, listaJugadores,aleatorio1,aleatorio2);
            
            
        }

        public void MostrarListaCompetidores(modelo p1, modelo p2)
        {
            lblNombre1.Text = $"Nombre: {p1.Nombre.ToString()}";
            lblApodo1.Text = $"Apodo: {p1.Apodo.ToString()}";
            lblEspecie.Text = $"Especie: {p1.Raza.ToString()}";
            lblVida1.Text = $"Puntos de Vida: {p1.PuntosVida.ToString()}";
            lblFuerza1.Text = $"Fuerza: {p1.Fuerza.ToString()}";
            lblArmadura1.Text = $"Armadura: {p1.Armadura.ToString()}";

            lblNombre2.Text = $"Nombre: {p2.Nombre.ToString()}";
            lblApodo2.Text = $"Apodo: {p2.Apodo.ToString()}";
            lblEspecie2.Text = $"Especie: {p2.Raza.ToString()}";
            lblVida2.Text = $"Puntos de Vida: {p2.PuntosVida.ToString()}";
            lblFuerza2.Text = $"Fuerza: {p2.Fuerza.ToString()}";
            lblArmadura2.Text = $"Armadura: {p2.Armadura.ToString()}";
        }

        public void GenerarBatalla(List<modelo> Eliminados,List<modelo> Lista, int num1, int num2)
        {
            int power1 = Lista[num1].Armadura + Lista[num1].Fuerza + Convert.ToInt32(Lista[num1].PuntosVida);
            int power2 = Lista[num2].Armadura + Lista[num2].Fuerza + Convert.ToInt32(Lista[num2].PuntosVida);

            if(power1 >= power2)
            {
                lblGanador.Text = "El ganador de esta batalla fue: " + Lista[num1].Nombre;
                Eliminados.Add(Lista[num2]);
                listaPerdedores.Items.Add(Eliminados);
                Lista.RemoveAt(num2);
                foreach (modelo eliminado in Eliminados)
                {
                    listaPerdedores.Items.Add(modelo.mostrarPersonaje(eliminado));
                }
            }
            else
            {
                lblGanador.Text = "El ganador de esta batalla fue: " + Lista[num2].Nombre;
                Eliminados.Add(Lista[num1]);
                listaPerdedores.Items.Add(Eliminados);
                Lista.RemoveAt(num1);
                foreach (modelo eliminado in Eliminados)
                {
                    listaPerdedores.Items.Add(modelo.mostrarPersonaje(eliminado));
                }
            }

        }
    }
}
