

using System;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            string nombre= "Hugo";
            nombre = "Luis";
            //Y la utilizamos dentro de un bloque interno
            edad = 45;
            var p = new Persona();
            p.paisOrigen = "Perú";
            Console.Read();
        }

        //nombre = "Kyra";
        //Definimos la variable edad dentro de un bloque externoa
        static int edad = 21;
        class Persona
        {
            public string paisOrigen;
            private int edad2;
            public int obtenerEdad()
            {
                return edad2;
            }
        }
    }
}
