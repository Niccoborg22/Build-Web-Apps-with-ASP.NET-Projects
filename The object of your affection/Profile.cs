public class Profile
{
    private string name;
    private int age;
    private int Age
    {
        get { return age;}
        set 
        {
            if(value < 18)
            {
                Console.WriteLine("Unfortunately we can't accept under age profiles. Your age has been set to 18\n");
                age = 18;
            }
            else
            {
                age = value;
            }
        }
    }
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
        this.name = name;
        this.Age = Age;
        this.city = city;
        this.country = country;
        this.pronouns = pronouns;
    }

    public string ViewProfile()
    {
        if(hobbies.Length > 0)
        {
            string hobbyList = "";
            for(int i = 0;i<hobbies.Length;i++)
            {
                if(i==0)
                {
                    hobbyList = $"{hobbies[i]}";
                }
                else
                {
                    hobbyList = $"{hobbyList}, {hobbies[i]}";
                }

            }
            return $"PROFILE\n---------------------\nName: {name}\nAge: {age}\nCountry: {country}\nCity: {city}\nPronouns: {pronouns}\nHobbies: {hobbyList}";
        }
        else
        {
            return $"PROFILE\n---------------------\nName: {name}\nAge: {age}\nCountry: {country}\nCity: {city}\nPronouns: {pronouns}\nHobbies: None";
        }
    }

    public void SetHobbies(string[] hobbies)
    {
        this.hobbies = hobbies;
    }
}