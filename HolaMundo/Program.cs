

using System;
using System.Collections.Generic;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>() { "Hugo", "Kyra", "Dayron" };

             //for (int i = 0; i < nombres.Count; i++)
             //{
             //   //Editando la Lista.
             //   nombres[i] = nombres[i] + "s";
             //    Console.WriteLine(nombres[i].ToUpper());
             //} 
            foreach (string nombre in nombres)
            {
               Console.WriteLine(nombre.ToUpper());
            }
              Console.Read();                     
        }     
    }
}
