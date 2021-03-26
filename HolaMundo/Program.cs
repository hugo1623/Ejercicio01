

using System;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Hugo";
            String nombreMayuscula = "HUGO";
            string frase = "Morir vivir que sentido tiene sin el placer de luchar";
            var longitudNombre = nombre.Length;
            //Interpolación de cadena.
            Console.WriteLine( $" La longitud del Nombre es: { longitudNombre}" );
            if(longitudNombre !=4)
            {
                Console.WriteLine(frase.Length);
            }
            else if( longitudNombre == 4)
            {
                Console.WriteLine("Longitud es 4");
            }
            else
            {
                Console.WriteLine(nombre == nombreMayuscula);
            }
 
            Console.Read();
        }

        
    }
}
