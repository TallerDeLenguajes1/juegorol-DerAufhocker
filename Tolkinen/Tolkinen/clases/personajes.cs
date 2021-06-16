using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolkinen.clases
{
    public enum tipoRaza
    {
        Humano,
        Enano,
        Orcos,
        Troll,
        Elfo
    }
    public class personajes
    {
        private tipoRaza raza;//Usar esto tiene la ventaja de que está todo predefinido, tambien podemos usar el switch porque los enum estan ordenados
        private string nombre;
        private string apodo;
        private DateTime fechaNac;
        private int edad;
        private float salud;

        private int velocidad;
        private int destreza;
        private int fuerza;
        private int nivel;
        private int armadura;

        //este es el constructor
        public personajes(tipoRaza raza, string nombre, string apodo, DateTime fechaNac, int edad, float salud)
        {
            Raza = raza;
            Nombre = nombre;
            Apodo = apodo;
            FechaNac = fechaNac;
            Salud = salud;
        }

        public tipoRaza Raza { get => raza; set => raza = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apodo { get => apodo; set => apodo = value; }
        public DateTime FechaNac  { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public float Salud { get => salud; set => salud = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Destreza { get => destreza; set => destreza = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }


    }
}
