using System;
using System.Diagnostics;
using System.Timers;

namespace Asistencia2.Clases
{
    public class Tiempo
    {
        static Stopwatch stopwatch = new Stopwatch();

        Timer tiempo;
        public string hora = "";

        public Tiempo()
        {
            tiempo = new Timer();
            tiempo.Interval = 60000;
            tiempo.Elapsed += new ElapsedEventHandler(tiempo_Elapsed);

            tiempo.Enabled = true;

            stopwatch.Start();
        }

        public void tiempo_Elapsed(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToShortTimeString();
            Console.WriteLine(hora);
        }

        public void Stop()
        {
            stopwatch.Stop();
            TimeSpan tiempo_uso = stopwatch.Elapsed;
            Console.WriteLine("Tiempo de uso: {0} segundos.", tiempo_uso.TotalSeconds);
        }
    }
}
