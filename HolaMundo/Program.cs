

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
            //    Console.WriteLine(nombres[i].ToUpper());
            //}

            int j = 0;
            while( j< nombres.Count)
            {
                Console.WriteLine(nombres[j].ToUpper());
                j++;
            }
              Console.Read();                     
        }     
    }
}
