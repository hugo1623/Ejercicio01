

using Operaciones;
using System;
namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona {nombre = "Luis", edad = 26};
            persona = null;

            Nullable<int> numero = 45;
            numero = null;
            DateTime? fechaDeNacimiento = null;
            fechaDeNacimiento = new DateTime(2021 / 04 / 02);
            if(numero.HasValue)
            {
                Console.WriteLine("El número tiene valor");
            }
            if(fechaDeNacimiento.HasValue)
            {
                Console.WriteLine("La fecha tiene valor");
            }
            Console.Read();
        }
        class Persona
        {
                public string nombre;
                public int edad;
        }
    }
}