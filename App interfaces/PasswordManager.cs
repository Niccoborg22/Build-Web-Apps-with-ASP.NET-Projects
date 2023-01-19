
class PasswordManager : IDisplayable,IResetable
{
  // Set method to check the numbers of characters in the password inputted
  private string password;
  private string Password
  {
    get {return password;}
    set
    {
      if(value.Length < 8)
      {
        Console.WriteLine("You have not entered enough characters, your password has been set to ABCDEFGHI");
        value = "ABCDEFGHI";
        password = value;
      }
      else
      {
        password = value;
      }
    }
  }

  public bool Hidden
  { get; private set; }

  public PasswordManager(string password, bool hidden)
  {
    Password = password;
    Hidden = hidden;
  }

  // Method to satisfy the IDisplayable interface
  public void Display()
  {
    if(Hidden == false)
    {
      Console.WriteLine("The current password is: " + Password);
    }
    else
    {
      Console.WriteLine("The current password is: *********");
    }
  }

    // Method to satisfy the IResetable interface
  public void Reset()
  {
    Password = "";
    Hidden = false;
  }

  // Method to change the password
  public void ChangePassword(string currentP, string newP)
  {
    if(currentP == Password)
    {
      Password = newP;
      Console.WriteLine("The password has just been changed");
    }
    else
    {
      Console.WriteLine("You have not entered the correct password. The password has NOT been changed");
    }
  }
}