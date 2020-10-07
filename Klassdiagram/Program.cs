using System.Threading;
using System.Runtime.ExceptionServices;
using System;

namespace Klassdiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi first = new Tamagotchi();

            name(first);

            while(first.GetAlive() == true)
            {
                System.Console.WriteLine(first.name);
                first.PrintStats();

                Choice(first);

                first.Tick();

                Console.Clear();
            }
            
            GameOver();
        }
        static void name(Tamagotchi first)
        {
            System.Console.WriteLine("Name your pet:");;
            first.name = Console.ReadLine();    
            Console.Clear();
        }
        static void Choice(Tamagotchi first)
        {
            System.Console.WriteLine("a. Teach word");
                System.Console.WriteLine("b. Say hi");
                System.Console.WriteLine("c. Feed pet");
                System.Console.WriteLine("d. Nothing");

                string answer = Console.ReadLine().Trim().ToLower();

                answerControl(answer);

                if(answer == "a")
                {
                    first.Teach(Console.ReadLine());
                }
                else if(answer == "b")
                {
                    first.Hi();
                }
                else if(answer == "c")
                {
                    first.Feed();
                }
                else if(answer == "d")
                {
                    
                }
        }
        static void answerControl(string answer)
        {
            while(answer != "a" || answer != "b" || answer != "c" || answer != "d")
            {
                System.Console.WriteLine("Wrong input!");
            }
        }
        static void GameOver()
        {
            System.Console.WriteLine();
        }
    }
}
