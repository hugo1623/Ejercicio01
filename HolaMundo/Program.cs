

using System;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 8;
            var d = 9;

            Console.WriteLine("Operaciones Lógicas");
            var booleano = true;
            Console.WriteLine("Operación Negación: !{0}={1}", booleano,!booleano);

            Console.WriteLine("Conjunción");
            Console.WriteLine("{0} & {0} = {1}", true, true & true);
            Console.WriteLine("{0} & {0} = {1}", false, false & false);
            Console.WriteLine("{0} & {1} = {2}", true, false, true & false);
            Console.WriteLine("");

            Console.WriteLine("Disyunción Exclusiva");
            Console.WriteLine("{0} ^ {0} = {1}", true, true ^ true);
            Console.WriteLine("{0} ^{0} = {1}", false, false ^ false);
            Console.WriteLine("{0} ^ {1} = {2}", true, false, true ^ false);
            Console.WriteLine("");
            
            Console.WriteLine("Disyunción Inclusiva");
            Console.WriteLine("{0} | {0} = {1}", true, true | true);
            Console.WriteLine("{0} | {1} = {2}", true, false, true | false);
            Console.WriteLine("{0} | {0} = {1}", false, false | false);
           
            Console.WriteLine("");
            Console.Read();Console.Read();

        }
    }
}
