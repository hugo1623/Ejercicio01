

using System;
using System.Collections.Generic;

namespace HolaMundo
{

     class Program
    {
        static void Main(string[] args)
        {

            string statusOperaciones = "K15";
            if(statusOperaciones == EstatusOperaciones._exitoso)
            {
                //..
            }
            else if (statusOperaciones == EstatusOperaciones._ClienteNoEncontrado)
            {
                //..
            }
            else if (statusOperaciones == EstatusOperaciones._ErrorDelSistema)
            {
                //..
            }
            Console.Read();                     
        }    
        public static class EstatusOperaciones
        {
            public const string _exitoso = "K120";
            public const string _ClienteNoEncontrado = "P4";
            public const string _ErrorDelSistema = "K15";
        }
    }
}
