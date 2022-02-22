using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which animal do you want to hear?\n" +
                              "1. Bird\n2. Cat\n3. Dog\n4. Lion (My own Animal class\n5. Pig");
            var choice = Convert.ToInt32(Console.ReadLine());

            //The editor simply suggested this as an action when I wrote out a whole switch statement. BUt it's pretty
            //cool and I'll remember its a thing because that can be handy sometimes.
            Animal animal = choice switch
            {
                1 => new Bird(),
                2 => new Cat(),
                3 => new Dog(),
                4 => new Lion(),//My Class
                5 => new Pig(),
                _ => null
            };

            animal?.MakeNoise();
            animal?.Sleep();
        }
    }
}
