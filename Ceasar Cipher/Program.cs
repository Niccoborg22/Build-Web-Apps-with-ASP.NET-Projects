internal class Program
{
    private static void Main(string[] args)
    {
        char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      
        // Ask the user for a secret message to be encrypted and transform it into a char array
        Console.WriteLine("CEASER CIPHER\nPlease insert a word to be encrypted: ");
        string word = Console.ReadLine().ToLower();
        char[] secretMessage = word.ToCharArray();
        char[] encryptedMessage = new char[secretMessage.Length];

        // Char by char encryption
        for(int i=0;i<secretMessage.Length;i++)
        {
            char currentChar = secretMessage[i];
            if(alphabet.Contains(currentChar))
            {
                int alphabetPosition = Array.IndexOf(alphabet, currentChar);
                encryptedMessage[i] = alphabet[(alphabetPosition + 3)%alphabet.Length];
            }
            else
            {
                continue;
            }
        }

        // Convert it back to a word
        string encryptedWord = String.Join("", encryptedMessage);
        Console.WriteLine("The encrypted word is: " + encryptedWord);
    }

}