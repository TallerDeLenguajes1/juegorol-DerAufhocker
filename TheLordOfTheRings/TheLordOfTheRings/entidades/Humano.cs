using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLordOfTheRings.entidades
{
    public class Humano : modelo
    {
        Random random = new Random();
        int vidaHumana = 100;
        int velocidadHumana = 50;
        int fuerzaHumana = 50;
        int armaduraHumana = 100;
        //parametros del constructor
       
        public Humano() : base()
        {

        }
        public Humano(TipoEspecie especie,string nombre, string apodo, string nacimiento) : base()
        {
            Raza = especie;
            Nombre = nombre;
            Apodo = apodo;
            FechNac = Convert.ToDateTime(nacimiento);
        }

        public Humano(TipoEspecie especie, string nombre, string apodo, string nacimiento, int edad,
            int puntosVida, int velocidad, int destreza, int fuerza, int nivel, int armadura) 
        {
            Raza = especie;
            Nombre = nombre;
            Apodo = apodo;
            FechNac = Convert.ToDateTime(nacimiento);
            Edad = CalcularEdad(FechNac);
            PuntosVida = vidaHumana;
            Velocidad = random.Next(1, velocidadHumana);
            Destreza = random.Next(1, 10);
            Fuerza = random.Next(1, fuerzaHumana);
            Nivel = 1;
            Armadura = random.Next(1, armaduraHumana);
        }

        public int CalcularEdad(DateTime nacimiento)
        {
            int edad = DateTime.Now.Year - nacimiento.Year;
            if(DateTime.Now.Month < nacimiento.Month)
            {
                return edad--;
            }
            else
            {
                if((DateTime.Now.Month == nacimiento.Month) && (DateTime.Now.Day < nacimiento.Day ))
                {
                    return edad--;
                }
              
            }
            return Edad;
        }
    
       
    }
}
