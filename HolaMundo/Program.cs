

using System;

namespace HolaMundo
{
     class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2021, 03, 22);
            DateTime fechaConHora = new DateTime(2021, 03, 25, 3, 28, 15);
            
            Console.WriteLine(fecha.ToString());
            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dd-MM-yy"));
            Console.WriteLine(fechaConHora.ToString("dd-MM-yy hh:mm:ss"));
            //Muestra la fecha 45 dias despues de la fecha actual
            Console.WriteLine(fecha.AddDays(45).ToString());
            //Que dia de la semana es esa fecha (Lunes 22)
            Console.WriteLine(fechaConHora.DayOfWeek);
            Console.WriteLine(fechaConHora.Date);
            //Cuantos dias hay entre fecha y fechaConHora.
            Console.WriteLine(fecha.Subtract(fechaConHora).Days);
            
            Console.Read();
        }
    }
}
