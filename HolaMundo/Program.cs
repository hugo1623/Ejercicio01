

using Operaciones;
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

    }
}