using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLordOfTheRings.entidades
{
    public enum nombreUruk {Kazzu, Bolgo,Azzoc }
    public class Uruk_Hai
    {
        public nombreUruk nombre;
        public double puntosVida;
        public int velocidad;
        public int destreza;
        public int fuerza;
        public int nivel;
        public int armadura;

        public Uruk_Hai(nombreUruk nombre, double puntosVida, int velocidad, 
            int destreza, int fuerza, int nivel, int armadura)
        {
            this.nombre = nombreUruk.Kazzu;
            this.puntosVida = 0;
            this.velocidad = 0;
            this.destreza = 0;
            this.fuerza = 0;
            this.nivel = 0;
            this.armadura = 0;
        }
    }
}
