using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLordOfTheRings2
{
    public enum TipoEspecie { Humano, Elfo, Enano}
    class modeloPersonaje
    {
        private TipoEspecie raza;
        private string nombre;
        private string apodo;
        private DateTime fechNac;
        private int edad;
        private double puntosVida;

        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        public modeloPersonaje(TipoEspecie raza, string nombre, string apodo, DateTime fechNac)
        {
            this.raza = raza;
            this.nombre = nombre;
            this.apodo = apodo;
            this.fechNac = fechNac;
        }

        public TipoEspecie Raza { get => raza; set => raza = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechNac { get => fechNac; set => fechNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public double PuntosVida { get => puntosVida; set => puntosVida = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
    }
}
