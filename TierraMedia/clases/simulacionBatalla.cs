using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierraMedia.clases
{
    class simulacionBatalla
    {
        crearPersonajeAleatorio creadorDePersonajes = new crearPersonajeAleatorio();
        personajes player1 = creadorDePersonajes.crearPersonaje();
    }
}
