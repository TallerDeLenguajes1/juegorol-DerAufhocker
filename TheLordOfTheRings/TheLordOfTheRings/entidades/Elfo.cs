using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLordOfTheRings.entidades
{
    class Elfo : modelo
    {
        Random random = new Random();
        int vidaElfo = 150;
        int velocidadElfo = 70;
        int fuerzaElfo = 40;
        int armaduraElfo = 40;

        public Elfo() : base()
        {

        }
        public Elfo(TipoEspecie especie, string nombre, string apodo, string nacimiento) : base()
        {
            Raza = especie;
            Nombre = nombre;
            Apodo = apodo;
            FechNac = Convert.ToDateTime(nacimiento);
        }

        public Elfo(TipoEspecie especie, string nombre, string apodo, string nacimiento, int edad,
            int puntosVida, int velocidad, int destreza, int fuerza, int nivel, int armadura) : base()
        {
            Raza = especie;
            Nombre = nombre;
            Apodo = apodo;
            FechNac = Convert.ToDateTime(nacimiento);
            Edad = CalcularEdad(FechNac);
            PuntosVida = vidaElfo;
            Velocidad = random.Next(1, velocidadElfo);
            Destreza = random.Next(1, 10);
            Fuerza = random.Next(1, fuerzaElfo);
            Nivel = 1;
            Armadura = random.Next(1, armaduraElfo);
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
