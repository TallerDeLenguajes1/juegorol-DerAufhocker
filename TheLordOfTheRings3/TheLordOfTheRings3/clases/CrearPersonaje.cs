using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLordOfTheRings3.clases
{

    class CrearPersonaje
    {
        List<string> listaEspecies = new List<string>() { "Hombre", "enano", "Elfo", "Orco", "Uruk-Hai" };

        List<string> listaApodos = new List<string>() { "Cabeza de Hierrro", "lomo Plateado", "Brazo de Hierrro", "Señora de las moscas", "señora de las bubis" };

        public List<string> listaNombres = new List<string>()
        {
            "Lilen",
            "Gaby",
            "Day",
            "Exequiel",
            "Karen",
            "Gustavo",
            "Carla",
            "Vanina"
        };

        public Random rand = new Random();
        public DateTime fechaRandom()
        {
            DateTime fechaInicio = new DateTime(1993, 1, 1);
            int rangoFecha = (DateTime.Today - fechaInicio).Days;
            return fechaInicio.AddDays(rand.Next(rangoFecha));
        }
        public modelo CrearPersonajeAletorio(int num)
        {
           Random random = new Random();
            
            modelo personajeAleatorio = new modelo(listaEspecies.ElementAt(random.Next(listaEspecies.Count)),
                                                    listaNombres.ElementAt(random.Next(listaNombres.Count)),
                                                    listaApodos.ElementAt(random.Next(listaApodos.Count)),
                                                    fechaRandom());
            personajeAleatorio.Nombre = listaNombres[num];
            personajeAleatorio.Edad =personajeAleatorio.CalcularEdad(personajeAleatorio.FechNac);
            personajeAleatorio.Armadura = random.Next(1, 10);
            personajeAleatorio.PuntosVida = random.Next(90, 200);
            personajeAleatorio.Fuerza = random.Next(1, 10);
            personajeAleatorio.Destreza = random.Next(1, 10);
            personajeAleatorio.Velocidad = random.Next(1, 10);
            personajeAleatorio.Nivel = 1;

            return personajeAleatorio;
        }




    }
}
