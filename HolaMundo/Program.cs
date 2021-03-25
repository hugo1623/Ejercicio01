

using System;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            string nombre= "Hugo";
            string frase = "Morir vivir que sentido tiene sin el placer de luchar";


            Console.WriteLine("*** Length ***");
            Console.WriteLine(nombre.Length);
            Console.WriteLine(frase.Length);

            Console.WriteLine("\n*** Substring ***");
            Console.WriteLine(nombre.Substring(2));
            //A partir del sexto caracter queremos 6 caracteres
            Console.WriteLine(frase.Substring(6, 6));

            Console.WriteLine("\n*** Startswith *** ");
            //frase empieza con morir lo cual debe ser verdadero.
            Console.WriteLine(frase.StartsWith("inframundo"));
            Console.WriteLine(frase.StartsWith("Morir"));

            Console.WriteLine("\n*** enswith ***");
            Console.WriteLine(frase.EndsWith("luchar"));
            Console.WriteLine(frase.EndsWith("Morir"));

            Console.WriteLine("\n*** Contains ***");
            Console.WriteLine(frase.Contains("Hugo"));
            Console.WriteLine(frase.Contains("placer"));

            Console.Read();
        }

        
    }
}
