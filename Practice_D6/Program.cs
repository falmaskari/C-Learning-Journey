namespace Day_s_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Setfname("Fatma");
            p1.Setlname("Almaskari");
            p1.SetAge(23);
            p1.SetSalary(900.5);
            p1.SetRel("No");
            Console.WriteLine(p1.printInfo());
        }
    }
}
