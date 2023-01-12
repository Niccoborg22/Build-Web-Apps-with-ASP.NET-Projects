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
        Console.WriteLine("Do you want to decrypt the word? yes/no");
        string answerDec = Console.ReadLine().ToLower();
        switch(answerDec)
        {
            case "yes":
                Console.WriteLine("The decrypted word is " + Decrypt(encryptedWord));
                break;
            case "no":
                Console.WriteLine("Keep your misteries.");
                break;
            default:
                Console.WriteLine("Not clear answer, the decrcrypted word is " + Decrypt(encryptedWord));
                break;
        }
    }

    static string Decrypt(string word)
    {
        char[] alphabetDecrypt = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        char[] wordToChar = word.ToCharArray();
        char[] decryptedMessage = new char[wordToChar.Length];
        for(int i=0;i<wordToChar.Length;i++)
        {
            char current = wordToChar[i];
            int alphabetPos = Array.IndexOf(alphabetDecrypt, current);
            if(alphabetPos==2)
            {
                decryptedMessage[i] = alphabetDecrypt[(25)];
            }
            else if(alphabetPos==1)
            {
                decryptedMessage[i] = alphabetDecrypt[(24)];
            }
            else if(alphabetPos==0)
            {
                decryptedMessage[i] = alphabetDecrypt[(23)];
            }
            else
            {
                decryptedMessage[i] = alphabetDecrypt[(alphabetPos - 3)];
            }
        }
        string decryptedWord = String.Join("", decryptedMessage);
        return decryptedWord;
    }
}