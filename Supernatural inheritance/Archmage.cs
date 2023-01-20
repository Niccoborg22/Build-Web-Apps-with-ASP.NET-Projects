class Archmage : Mage
{
    // Constructor for the Archmage class
    public Archmage(string title) : base(title)
    {}

    // Overridden method of casting a rain storm
    public override Storm CastRainStorm()
    {
        Storm rainStorm = new Storm("rain",true,Title);
        return rainStorm;
    }

    // New method to cast a lighting storm
    public  Storm CastLightningStorm()
    {
        Storm lightningStorm = new Storm("lightning",true,Title);
        return lightningStorm;
    }
}