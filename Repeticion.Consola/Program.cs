using System;
//la librería que me tiene todo lo necesaria para trabajar con hilos
using System.Threading;
namespace Repeticion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el hilo
            Thread hilo = new Thread(new ThreadStart(OtraRepeticion));
            hilo.Start();
            //este for va a repetir 10 ceros al mismo tiempo que,El for  de abajo va a repetir 10 unos
            for (int k = 2; k <= 10; k++)
            {
                Console.Write("1");
            }

            //Instanciando mi clase mensaje para obtener los métodos de la clase mensaje
            Mensaje repetidor = new Mensaje();
            repetidor.Mensaje1();
            repetidor.Mensaje2();
            repetidor.Mensaje3();


            //me permite ver en cuanto tiempo se ejecuta el for
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine(i + ".-" + repetidor.Mensaje1());

            }
            Console.WriteLine("------------------------ Aquí terminan las repeticiones del mensaje número uno-----------------------");

            for (int j = 2; j <= 2000; j++)
            {
                Console.WriteLine(j + ".-" + repetidor.Mensaje2());

            }

            Console.WriteLine("------------------------ Aquí terminan las repeticiones del mensaje número dos ------------------------");
            for (int j = 2; j <= 3000; j++)
            {
                Console.WriteLine(j + ".-" + repetidor.Mensaje3());

            }

            watch.Stop();

            //tiempo del proceso en ticks
            var ticksTranscurridos = watch.ElapsedTicks;
            Console.WriteLine($"El tiempo transcurriedo de la repeticion de los mensajes fué de {ticksTranscurridos} ticks");
            //tiempo del proceso en milisegundos
            var milisegundoTranscurridos = watch.ElapsedMilliseconds;
            Console.WriteLine($"El tiempo transcurriedo de la repeticion de los mensaje fué de {milisegundoTranscurridos} milisegundos");


            Console.ReadKey();

        }

        static void OtraRepeticion()
        {
            //Este for va a repetir 10 ceros al mismo tiempo, El for de arriba va a repetir 10 unos
            for (int k = 2; k <= 10; k++)
            {
                Console.Write("0");

            }
        }
    }
}