

using System;

namespace HolaMundo
{
    public class Program
    {

        //Hacer un programa que le guste al usuario su nombre y edad, posterior a eso debe mostrar un mensaje en pantalla con el nombre del usuario y su edad.
        //Pista1: Utilice console.ReadLine para leer la información que ingrese el usuario.
        //Pista2: utilice int.Parse para convertir de tipo string a tipo int. 
        static void Main(string[] args)
        {
            string nombre;
            int edad;

            Console.Write("Ingrese su Nombre : ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su Edad : ");
            edad = int.Parse(Console.ReadLine());

            String output = string.Format("Su nombre es {0} y tiene {1} amos de edad", nombre, edad);
            Console.WriteLine(output);
            Console.Read();
        }

    }
}
