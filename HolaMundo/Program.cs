

using System;

namespace HolaMundo
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int multiplicando1 = 5;
            int multiplicando2 = 7;
            int multiplicando3 = 2;
            int resultado = Multiplicacion(multiplicando1, multiplicando2, multiplicando3);
            Console.WriteLine(resultado);
            Console.Read();
        }
        //Método Multiplicación
         static int Multiplicacion(int a, int b, int c)
        {
            return a * b * c;
        }
        
    }
}
