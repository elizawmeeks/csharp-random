using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eliza is the best!");

            // Create a list
            // Populate the list

            Random rando = new Random();
            List<double> randoList = new List<double>();
            for (double i = 0; i < 20; i++){
                double currentNum = rando.Next(1, 50);
                randoList.Add(currentNum);
            }

            List<double> randoSquared = new List<double>();
            foreach (double thing in randoList){
                double currentThing = Math.Pow(thing, 2);
                randoSquared.Add(currentThing);
                if (currentThing%2 == 1){
                    randoSquared.Remove(currentThing);
                }
            }

            foreach (double thing in randoSquared){
                Console.WriteLine(thing);
            }


        }
    }
}
