using System;
using System.Collections.Generic;
namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    throw new ApplicationException("No me gusta el 5");
                }
            }
            Console.Read();
        }
        static int CalcularEdad(DateTime fechaNacimiento)
        {
            return -1;
        }
        class Persona
        {
            public string nombre;
            public int edad;
        }
    }
}