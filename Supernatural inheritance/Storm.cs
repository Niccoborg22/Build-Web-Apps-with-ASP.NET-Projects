class Storm
{
    // Definition of the properties of the storm, public to access, private to set
    public string Essence
    { get; private set;}
    
    public bool IsStrong
    { get; private set;}

    public string Caster
    { get; private set;}

    // Storm constructor definition
    public Storm(string essence, bool isStrong, string caster)
    {
        Essence = essence;
        IsStrong = isStrong;
        Caster = caster;
    }

    // Method to print that the storm happened 
    public string Announce()
    {
        if(IsStrong == true)
        {
            return $"{Caster} cast a strong {Essence} storm";
        }
        else
        {
            return $"{Caster} cast a weak {Essence} storm";
        }
    }
}