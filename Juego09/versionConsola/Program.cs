using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versionConsola
{
    class Program
    {
        //declaracion de variables
        public static personajes Player1 = new personajes();//instancio mi variable y creo un objeto de tipo personajes

        static void Main(string[] args)
        {
            Start();
        }
        
        private static void Start()
        {
            Console.WriteLine("\nEscribe tu nombre:\n");
            Player1.Nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Tú {Player1.Nombre} eres la persona encargada de proteger de los ataques de los Orcos.");
            Console.WriteLine("")
        }
    }
}
