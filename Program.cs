using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int time = 10;
            int currentTime = 0; // Minuto atual

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //Thread é a execução atual do programa, e nós mandamos ela "dormir" por 1sec
            }
       }
    }
}