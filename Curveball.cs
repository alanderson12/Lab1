using System;

namespace _221StarterCode
{
    public class Curveball : IPitch
    {
        //if a curveball is called, this will write to screen
        public void Pitch()
        {
            Console.WriteLine("A 84 mph curveball was thrown. ");
        }
    }
}