internal class Program
{
    private static void Main(string[] args)
    {
        // Password manager 
        Console.WriteLine("PASSWORD MANAGER SCORER");

        // Password standards to be met
        int minLength = 8;
        string lowercase = "qwertyuiopasdfghjklzxcvbnm";
        string uppercase = lowercase.ToUpper();
        string digits = "1234567890";
        string specialChars = "()!@#$%";

        // Input from the user 
        Console.WriteLine("Please enter a password: ");
        string password = Console.ReadLine();

        // Password score according to the various criterias
        int score = 0;
        // If the password is longer than the minimum lenght - variable Lenght -, higher grade
        if(password.Length >= minLength){
            score ++;
        }
        // If the password contains uppercase letters - variable uppercase -, higher grade
        if(Tools.Contains(password, uppercase)){
            score ++;
        }
        // If the password contains lowercase letters - variable lowercase -, higher grade
        if(Tools.Contains(password, lowercase)){
            score ++;
        }
        // If the password contains digits - variable digits -, higher grade
        if(Tools.Contains(password, digits)){
            score ++;
        }
        // If the password contains special characters - variable specialChars -, higher grade 
        if(Tools.Contains(password, specialChars)){
            score ++;
        }
        
        // Print to the user the score of its password
        switch(score)
        {
            case 5:
            Console.WriteLine("password is extremely strong");
            break;
            case 4:
            Console.WriteLine("password is extremely strong");
            break;
            case 3:
            Console.WriteLine("password is strong");
            break;
            case 2:
            Console.WriteLine("password is medium");
            break;
            case 1:
            Console.WriteLine("password is weak");
            break;
            default:
            Console.WriteLine("the password does not match any standards");
            break;
        }
    }
}