using System;
using System.Diagnostics;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start(6);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao Stopwatch");
            Console.WriteLine("Escolha o tipo de tempo do Stopwatch: ");
            Console.WriteLine("1 - Crônometro");
            Console.WriteLine("2 - temporizador");
            short res = short.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o tempoo do Stopwatch: ");
            Console.WriteLine("S = Segundos => 10 segundos");
            Console.WriteLine("M = Minutos => 60 segundos");
            Console.WriteLine("0 = Sair");
            
             string data = Console.ReadLine().ToLower();
             char type = char.Parse(data.Substring(data.Length - 1, 1));
             int time = int.Parse(data.Substring(0, data.Length - 1));
             int multiplier = 1;

             
            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }
            switch (res)
            {
                case 1: PreStart(time * multiplier);
                    break;
                case 2: PreStartTemporizador(time * multiplier);
                    break;
                case 3: System.Environment.Exit(0); 
                    break;
            }
        
        
        }
        

        static void PreStart(int time )
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);

            
        }
        static void PreStartTemporizador(int time )
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Temporizador(time);

            
        }
    
        static void Start(int time)
        {
            
            int currentTime = 0;
            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }

        static void Temporizador(int time)
        {
            int currentTime = 0;
            while (time != currentTime)
            {
                Console.Clear();
                time--;
                Console.WriteLine(time);
                Thread.Sleep((2000));
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
                
            
       

        }
    
    }
}
