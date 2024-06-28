using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(6);
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quando tempo deseja contar?");

        


        }
        static void Start(int time) //adicionado o parâmetro 
        {
            int currentTime = 0; // Minuto atual

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //Thread é a execução atual do programa, e nós mandamos ela "dormir" por 1sec
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
       }
    }
}