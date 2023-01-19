internal class Program
{
    private static void Main(string[] args)
    {
        TodoList tdl = new TodoList();
        tdl.Add("Invite friends");
        tdl.Add("Buy decorations");
        tdl.Add("Party");

        PasswordManager pm = new PasswordManager("iluvpie", true);
    }
}