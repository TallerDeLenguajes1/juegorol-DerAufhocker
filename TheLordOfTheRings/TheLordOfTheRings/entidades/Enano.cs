using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLordOfTheRings.entidades
{
    class Enano : modelo
    {
        Random random = new Random();
        int vidaEnano = 100;
        int velocidadEnano = 30;
        int fuerzaEnano = 100;
        int armaduraEnano = 150;

        public Enano() : base()
        {
        }

        public Enano(TipoEspecie especie, string nombre, string apodo, string nacimiento) : base()
        {
            Raza = especie;
            Nombre = nombre;
            Apodo = apodo;
            FechNac = Convert.ToDateTime(nacimiento);
        }

        public Enano(TipoEspecie especie, string nombre, string apodo, string nacimiento, int edad,
            int puntosVida, int velocidad, int destreza, int fuerza, int nivel, int armadura) : base()
        {
            Raza = especie;
            Nombre = nombre;
            Apodo = apodo;
            FechNac = Convert.ToDateTime(nacimiento);
            Edad = CalcularEdad(FechNac);
            PuntosVida = vidaEnano;
            Velocidad = random.Next(1, velocidadEnano);
            Destreza = random.Next(1, 10);
            Fuerza = random.Next(1, fuerzaEnano);
            Nivel = 1;
            Armadura = random.Next(1, armaduraEnano);
        }

        public int CalcularEdad(DateTime nacimiento)
        {
            int edad = DateTime.Now.Year - nacimiento.Year;
            if (DateTime.Now.Month < nacimiento.Month)
            {
                return edad--;
            }
            else
            {
                if ((DateTime.Now.Month == nacimiento.Month) && (DateTime.Now.Day < nacimiento.Day))
                {
                    return edad--;
                }

            }
            return Edad;
        }

        
    }
}
