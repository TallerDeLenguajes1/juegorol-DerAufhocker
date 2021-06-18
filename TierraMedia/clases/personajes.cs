using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierraMedia.clases
{
// aca iran las caracteristicas del personaje que son ingresadas por el formulario
   
        public enum tipoRaza 
        { 
            Human,
            Hobbits,
            Dwarves,//enanos
            Elves,//elfos
        }
         public class personajes
        { 
            private tipoRaza raza;
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



        /*
         Siempre que creamos una clase necesitamos un constructor para inicializar valores
         */
        public personajes(tipoRaza raza, string nombre, string apodo, DateTime fechNac, int edad, double puntosVida)
            {
                this.raza = raza;
                this.nombre = nombre;
                this.apodo = apodo;
                this.fechNac = fechNac;
                this.edad = edad;
                this.puntosVida = puntosVida;
            }

            /// <summary>
            /// aca hacemos la encapsulaion de los datos
            /// la encapsulacion es una forma de proteger y aislar atributos y metodos de aquellos que no tienen acceso a dicha informacion
            /// ¿Cuando encapsular? 
            /// </summary>
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
            internal tipoRaza Raza { get => raza; set => raza = value; }

            //todo lo anterior son datos que el usuario debera ingresar. pero debemos crear valores aleatorios
            //y crear personajes random para probar el juego y es recomendable crear un metodo aparte del codigo de produccion
        }
}
