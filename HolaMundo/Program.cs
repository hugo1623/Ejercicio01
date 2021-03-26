

using System;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Hugo";
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

            Console.WriteLine("\n*** Indexof ***");
            //Se encuentra a partir del 6 caracter
            var indiceDeHugo = frase.IndexOf("vivir");
            //luis no es una subcadena de frase por tanto el metotodo IndexOf es-1.
            var indiceDeLuis = frase.IndexOf("Luis");
            Console.WriteLine(indiceDeHugo);
            Console.WriteLine(indiceDeLuis);

            Console.WriteLine("\n*** Operator + ****");
            Console.WriteLine(nombre + "," + frase);

            Console.WriteLine("\n*** ToLower ****");
            Console.WriteLine(frase.ToLower());

            Console.WriteLine("\n*** ToUpper ****");
            Console.WriteLine(frase.ToUpper());

            Console.WriteLine("\n*** Trim ****");
            string ejemploTrim = " Luis Hugo ";
            Console.WriteLine(ejemploTrim);
            Console.WriteLine(ejemploTrim.Trim());


            Console.WriteLine("\n*** Format ****");
            string ejemploFormat = "Felicidade {0} en tu cumpleaños {1}! {0}";
            var resultadoFormat = string.Format(ejemploFormat, nombre, 26);
            Console.WriteLine(resultadoFormat);

            Console.WriteLine("\n*** Replace ***");
            string ejemploReplace = ("Felicidades @nombre en tu cumpleaños número @edad");
            var resultadoReplace = ejemploReplace.Replace("@nombre", nombre);
            resultadoReplace = resultadoReplace.Replace("@edad", "26");
            Console.WriteLine(resultadoReplace);

            Console.WriteLine("\n*** IsNullOrwhiteSpace ***");
            string stringEspacioEnBlanco = "";
            string stringNullo = null;
            Console.WriteLine(string.IsNullOrWhiteSpace(stringEspacioEnBlanco));
            Console.WriteLine(string.IsNullOrWhiteSpace(stringNullo));
            Console.WriteLine(string.IsNullOrWhiteSpace(nombre));

            Console.Read();
        }

        
    }
}
