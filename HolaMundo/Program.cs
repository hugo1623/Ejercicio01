

using System;
using System.Collections.Generic;

namespace HolaMundo
{
    enum EstatusOperacion
    {
        Exitoso=1,
        ClienteNoEncontrado=2,
        ErrorDeSistema=5
    }
     class Program
    {
        static void Main(string[] args)
        {

            int statusOperaciones = 5;
            if(statusOperaciones == (int)EstatusOperacion.Exitoso)
            {
                //..
            }
            else if (statusOperaciones == (int)EstatusOperacion.ClienteNoEncontrado)
            {
                //..
            }
            else if (statusOperaciones == (int)EstatusOperacion.ErrorDeSistema)
            {
                //..
            }
            Console.Read();                     
        }     
    }
}
