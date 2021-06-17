using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierraMedia.clases
{
    //hago esta clase aparte para crear personajes aleatorios y probar el juego antes de que el usuario ingrese los datos
    //para ello creo un metodo que cree valores aleatorios. esto tiene que ser aparte del codigo anterior para no mezclar codigo del proyecto con el codigo de pruebaa
    public class crearPersonajeAleatorio//creador de personaje
    {
        public personajes crearPersonaje()//generico
        {
            Random random = new Random();
            personajes nuevoPersonaje = new personajes(tipoRaza.Dwarves,"Exe","Gurin",DateTime.Now,73,150);
            nuevoPersonaje.Velocidad = random.Next(1, 10);
            nuevoPersonaje.Fuerza = random.Next(1, 10);
            nuevoPersonaje.Destreza = random.Next(1, 10);
            nuevoPersonaje.Armadura = random.Next(1, 10);
            nuevoPersonaje.Nivel = random.Next(1, 10);

            return nuevoPersonaje;
        }

    }
}
