using System;
using System.Collections.Generic;

namespace Klassdiagram
{
    public class Tamagotchi
    {
        int hunger = 0;

        int boredom = 0;

        List<string> words = new List<string>();
        //public static List<string> words = new List<string>();

        bool isAlive = true;

        static Random generator = new Random(); 

        public string name;

        public void Feed ()
        {
            if(hunger > 0)
            {
                hunger = -1; 
            }
        }

        public void Hi ()
        {
           Console.WriteLine(words[generator.Next(0, words.Count)]);
           ReduceBoredom();     
        }

        public void Teach (string word)//Lägger till ett ord i listan.
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger = +1;
            boredom = +1;
            
            if(hunger >= 10 || boredom >= 10)
            {
               isAlive = false;
            }
        }

        public void PrintStats()
        {
            System.Console.WriteLine("hunger:" + hunger);
            System.Console.WriteLine("boredom" + boredom);

            if(isAlive == true)
            {
                System.Console.WriteLine("Alive");
            }
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        void ReduceBoredom()
        {
            boredom = -1;
        }

    }
}
