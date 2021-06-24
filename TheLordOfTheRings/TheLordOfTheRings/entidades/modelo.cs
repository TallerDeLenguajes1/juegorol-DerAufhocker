using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLordOfTheRings.entidades
{
    public enum TipoEspecie { Humano, Elfo, Enano}
    public class modelo
    {
        public TipoEspecie raza;
        public string nombre;
        public string apodo;
        public DateTime fechNac;
        public int edad;
        public double puntosVida;

        public int velocidad;
        public int destreza;
        public int fuerza;
        public int nivel;
        public int armadura;

        public modelo(TipoEspecie raza, string nombre, string apodo, DateTime fechNac)
        {
            this.raza = raza;
            this.nombre = nombre;
            this.apodo = apodo;
            this.fechNac = fechNac;
        }

        //constructor base
        /*
         public modelo()
         {
             this.raza = TipoEspecie.Humano;
             this.nombre = "";
             this.apodo = "";
             this.fechNac = DateTime.Now;
             this.edad = 0;
             this.puntosVida = 0;
             this.velocidad = 0;
             this.destreza = 0;
             this.fuerza = 0;
             this.nivel = 0;
             this.armadura = 0;
         }*/

        public TipoEspecie Raza { get => raza;  set => raza = value; }
        public string Nombre { get => nombre;  set => nombre = value; }
        public string Apodo { get => apodo;  set => apodo = value; }
        public DateTime FechNac { get => fechNac;  set => fechNac = value; }
        public int Edad { get => edad;  set => edad = value; }
        public double PuntosVida { get => puntosVida;  set => puntosVida = value; }
        public int Velocidad { get => velocidad;  set => velocidad = value; }
        public int Destreza { get => destreza;  set => destreza = value; }
        public int Fuerza { get => fuerza;  set => fuerza = value; }
        public int Nivel { get => nivel;  set => nivel = value; }
        public int Armadura { get => armadura;  set => armadura = value; }
    }

    
}
