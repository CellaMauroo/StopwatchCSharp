using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.Serialization.DataContracts;

namespace Stopwatch
{

    class Program
    {

        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - seconds => 10s = 10 sec.");
            Console.WriteLine("M - minute => 1m = 1 min.");
            Console.WriteLine("E - Exit.");
            Console.WriteLine("How much time do you want to count?");

            string data = Console.ReadLine().ToLower();
            char type = 'k';
            int time = 0;
            if (data.Length > 1)
            {
                type = char.Parse(data.Substring(data.Length - 1, 1));
                time = int.Parse(data.Substring(0, data.Length - 1));

            }
            else
            {
                type = char.Parse(data);
            }

            if (type == 'm')
            {
                Start(time * 60);
            }
            else if (type == 's')
            {
                Start(time);
            }
            else if (data == "e")
            {
                Console.WriteLine("Thanks for using the Stopwach.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid time format or 'E' to exit.");
                Thread.Sleep(2000);
                Menu();
            }

        }

        static void Start(int time)
        {

            int currentTime = 0;
            while (currentTime <= time)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime++;
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Stopwatch has ended.");
            Thread.Sleep(2500);
            Menu();
        }
    }


}