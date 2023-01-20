class Mage : Pupil
{
    // Constructor for the mage class
    public Mage(string title) : base(title)
    {}

    // Method to cast a new spell
    public virtual Storm CastRainStorm()
    {
        Storm rainStorm = new Storm("rain",false,Title);
        return rainStorm;
    }
}