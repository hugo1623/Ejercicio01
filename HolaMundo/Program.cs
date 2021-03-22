

using System;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        //Instanciar la clase persona
        //Persona es tipo de la variable que creamos y p el nombre de la variable 
        {
            Persona p = new Persona();
            p.Nombre = "Hugo";
            p.Edad = 26;
            p.Direccion = "Las Magnolias";
            p.MostrarDatosEnConsola();

            Persona p2 = new Persona();
            p2.Nombre = "Kyra";
            p2.Edad = 5;
            p2.Direccion = "San Isidro";
            p2.MostrarDatosEnConsola();

            Console.Read();
        }
        //Clase persona
         class Persona
        {
            public string Nombre;
            public int Edad;
            public string Direccion;


            public void MostrarDatosEnConsola()
            {
                string output = "El nombre es : {0}, la edad es :{1}, la dirección es: {2}";
                output = string.Format(output, Nombre, Edad, Direccion);
                Console.WriteLine(output);
            }
        }
    }
}
