using System;

namespace _221StarterCode
{
    public class Fastball : IPitch
    {
        //if a fastball is called, this will write to screen
        public void Pitch()
        {
            Console.WriteLine("A 94 mph fastball was thrown. ");
        }
    }
}