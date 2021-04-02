

using Operaciones;
using System;
namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 3;
            try
            {
                int c = a / b;
                Console.WriteLine($" El resultado es : {c}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Existe un error");
            }
            finally
            {
                Console.WriteLine("Siempre se va a ejecutar");
            }
            Console.Read();
        }
    }
}