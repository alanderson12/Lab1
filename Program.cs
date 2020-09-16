using System;
using System.IO;

namespace _221StarterCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //interface variables being called from classes
            IPitch fastball = new Fastball();
            IPitch curve = new Curveball();
            IPitch slider = new Slider();

            //setting craftyLefty with Pitcher interface as a new Lefty class with Name and Team
            Pitcher craftyLefty = new Lefty{Name = "Crafty Lefty", Team = "Mets"};

            //calling the pitch method
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a strike!");

            //getting pitch behavior as a fastball
            //calling the pitch method
            craftyLefty.SetPitchBehavior(fastball);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a strike!");

            //getting pitch behavior
            //calling the pitch method
            craftyLefty.SetPitchBehavior(slider);
            craftyLefty.pitchBehavior.Pitch();
            Console.WriteLine("That was a ball!");

            //getting pitch behavior as a curve
            //since this is the 3rd strike, batter is out
            craftyLefty.SetPitchBehavior(curve);
            Console.WriteLine("Strike 3! BATTER OUT!");
        }
    }
}
