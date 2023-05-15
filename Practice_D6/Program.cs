namespace Day_s_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] Arr = new int[7] { 1, 2, 7, 5, 8, 2, 1 };
            for (int i = 0; i < Arr.Length; i++)
            {
                for(int j = 0; j < Arr.Length; j++)
                {
                    if (Arr[i] == Arr[j])
                    {
                        Console.WriteLine(Arr[i]);
                        break;
                    }
                }
            }*/

            /*Person p1 = new Person();
            p1.Setfname("Fatma");
            p1.Setlname("Almaskari");
            p1.SetAge(23);
            p1.SetSalary(900.5);
            p1.SetRel("No");
            Console.WriteLine(p1.printInfo());*/

            Bank bank = new Bank();
            bank.Setdeposite(500);
            bank.Setwithdraw(500);
            bank.withDraw(500);
        }
    }
}
