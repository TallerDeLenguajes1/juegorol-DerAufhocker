using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versionConsola
{
    class personajes
    {
        public enum TipodePersonaje
        {
            Elfo,
            Orco,
            Humano,
            Hobbit,
        }

        private TipodePersonaje tipo;
        private string nombre;
        private string apodo;
        private DateTime fechadenacimiento;
        private int edad;
        private int salud;

        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        internal TipodePersonaje Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }


        private void nuevoPersonaje()
        { 
            Random rand = new Random();
            Salud = 100;
            edad = rand.Next(0, 300);
            Velocidad = rand.Next(1, 11);
            Destreza = rand.Next(1, 6);
            Fuerza = rand.Next(1, 11);
            Nivel = rand.Next(1, 11);
            Armadura = rand.Next(1, 11);
            switch (rand.Next(1, 6))
            {
                case 1:
                    tipo = TipodePersonaje.Elfo;
                    break;
                case 2:
                    tipo = TipodePersonaje.Hobbit;
                    break;
                case 3:
                    tipo = TipodePersonaje.Humano;
                    break;
                case 4:
                    tipo = TipodePersonaje.Orco;
                    break;
            }
        }
    }
}
