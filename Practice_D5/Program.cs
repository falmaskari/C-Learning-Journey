namespace Methods
{
    internal class Program
    {
        public static void PrintLine(int cnt=3, string pattern="@")
        {
            for (int i=0; i <= cnt; i++) 
            {
                Console.Write(pattern);
            }
            Console.WriteLine("");
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public static void SumMul(int x, int y, out int S, out int M)
        {
            S = x + y;
            M = x * y;
        }
        public static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("PLease enter the first number: ");
            x = int.Parse(Console.ReadLine());
            //caller : argument
            PrintLine(pattern: "@#*");

            Console.WriteLine("PLease enter the second number: ");
            y = int.Parse(Console.ReadLine());
            PrintLine();

            Console.WriteLine("PLease enter the third number: ");
            z = int.Parse(Console.ReadLine());
            PrintLine(15, "*&@");

            int a = 5, b = 7;
            Swap(ref a, ref b);
            Console.WriteLine("A is:" + a);
            Console.WriteLine("B is:" + b);

            int Sresult, Mresult;
            SumMul(a, b, out Sresult, out Mresult);
            Console.WriteLine("sum:" + Sresult);
            Console.WriteLine("Multiplicattion:" + Mresult);

            Calculator cal = new Calculator();
            int c = 5, d = 6;
            double e = 5.1, f = 6.8;
            string g = "hello", h = "world";
            Console.WriteLine(cal.add(c, d));
            Console.WriteLine(cal.add(e, f));
            Console.WriteLine(cal.add(g, h));
            int i = 5;

            Person p = new Person(1, "Fatma", "Almaskari", 23, false, "Seeker", "Sur");
            Person p1 = new Person("Fatma", "Almaskari", 23, false);
            p.Print();
            p1.Print();
        }

    }

}
