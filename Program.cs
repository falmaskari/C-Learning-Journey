namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phone = new PhoneBook(2); //Create instance from class
            phone[0, "Fatma"] = "1234";
            phone[1, "Saleh"] = "5678";
            Console.WriteLine(phone[0, "Fatma"]);
            Console.WriteLine(phone[1, "Saleh"]);
        }
    }
}