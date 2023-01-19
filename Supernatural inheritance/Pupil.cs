class Pupil
{
    // Property of the Pupil. Title is the name
    public string Title
    { get; private set; }

    // Constructor of the pupil class
    public Pupil(string title)
    {
        Title = title;
    }

    // Method to cast the only spell the Pupil can spell
    public Storm CastWindStorm()
    {
        Storm weakWind = new Storm("wind", false, Title);
        return weakWind;
    }
}