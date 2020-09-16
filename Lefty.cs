namespace _221StarterCode
{
    public class Lefty : Pitcher
    {
        
        //Lefty method called which sets a throw to left and sets the pitch behavior to a new curveball
        public Lefty()
        {
            Throws = "left";
            SetPitchBehavior(new Curveball());
        }

    }
}