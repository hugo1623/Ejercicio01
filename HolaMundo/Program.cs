

using Operaciones;
using System;
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
        /// <summary>
        /// Descripcion del Metodo
        /// </summary>
        /// <param name="a">Sumando 1</param>
        /// <param name="b">Sumando 2</param>
        /// <returns>Retorna la suma de a y b</returns>
        private static int Suma(int a, int b)
        {
            return a + b;
        }
    }
}