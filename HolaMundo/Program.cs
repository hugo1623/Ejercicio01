

using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de declaraciones de una variable
            int mes = 9;
            string nombre= "Hugo Luis";
            bool procesoTerminado = true;

            // Interpolacion de cadena
            Console.WriteLine(
                $"Nombre: {nombre} \n" +
                $"Mes: {mes} \n" +
                $"Proceso: {procesoTerminado}\n");
            Console.Read();
        }
    }
}
