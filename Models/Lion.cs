using System;

namespace AbstractExample.Models
{
    public class Lion : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("RAWWRRRRRR");
        }

        public override void Sleep()
        {
            Console.WriteLine("prrrr.... prrrrr...");
        }
    }
}