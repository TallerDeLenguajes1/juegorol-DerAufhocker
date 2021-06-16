using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tolkinen.clases
{
    public class crearPersonajeRandom
    {
        public personajes crearPersonaje()
        {
            Random random = new Random();
            personajes personajeRandom = new personajes(tipoRaza.Enano,"Exe","Gurin",DateTime.Now,73,100);
            personajeRandom.Velocidad = random.Next(1, 10);
            personajeRandom.Fuerza = random.Next(1, 10);
            personajeRandom.Destreza = random.Next(1, 10);
            personajeRandom.Armadura = random.Next(1, 10);
            personajeRandom.Nivel = random.Next(1, 10);
        }

    }

}
    

