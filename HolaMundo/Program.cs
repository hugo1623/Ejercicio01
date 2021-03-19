

using System;

namespace HolaMundo
{
    public class Program
    {
        static void Main(string[] args)
        {
            EscribiendoHolaMundo();
            EscribirEnLaConsola("Me llamo Hugo");
            IdentificadorDelMetodo("Valor1", "Valor2", 9);
            int sumando1 = 5;
            int sumando2 = 7;
            int resultado = Suma(sumando1,sumando2);
            Console.WriteLine(resultado);
            Console.Read();
        }
        //metodo Suma
         static int Suma(int a, int b)
        {
            return a + b;
        }
         static void EscribiendoHolaMundo()
        {
            Console.WriteLine("Hola Mundo");
        }
        static void EscribirEnLaConsola(string valor)
        {
            Console.WriteLine(valor);
        }
        static void IdentificadorDelMetodo(string parametro1, string parametro2, int etc)
        {
        }
    }
}
