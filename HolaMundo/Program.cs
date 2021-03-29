

using System;
using System.Collections.Generic;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();

            for (int i = 0 ; i < 10; i++)
            {
                if(i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

              Console.Read();                     
        }     
    }
}
