namespace _221StarterCode
{
    public class Pitcher
    {
        //getters and setters
        public string Name{get; set;}
        public string Team{get; set;}
        public string Throws{get; set;}
        public IPitch pitchBehavior;

        //method to set pitch behavior, set it to new variable "value"
        public void SetPitchBehavior(IPitch value)
        {
            pitchBehavior = value;
        }

        //method Pitcher to set pitch behavior to a new fastball
        public Pitcher()
        {
            SetPitchBehavior(new Fastball());
        }
    }
}
