using System;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convert from string to integer
            string a = "9999";
            int n = int.Parse(a);
            Console.WriteLine(n);
            int n1 = Convert.ToInt32(a);
            Console.WriteLine(n1);
            int n2 = int.TryParse(a, out int n3) ? n3:0;
            Console.WriteLine(n2);

            
            //Program for grading students marks
            Console.WriteLine("Enter student no:");
            double num = Convert.ToDouble(Console.ReadLine()); //Read input from user

            for(int i=0; i < num; i++)
            {
                Console.WriteLine("Enter student mark:");
                double mark = Convert.ToDouble(Console.ReadLine());

                if(mark<=100 && mark >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (mark <= 90 && mark >= 89)
                {
                    Console.WriteLine("B");
                }
                else if (mark <= 80 && mark >= 79)
                {
                    Console.WriteLine("C");
                }
                else if (mark <= 70 && mark >= 69)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            
            //Program to calculate area and circunference 
            const double pi = 3.14;
            Console.WriteLine("1. Area   2.Circunference");
            Double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter radius");
            Double r = Convert.ToDouble(Console.ReadLine());
            if (c == 1)
            {
                double Area = pi * Math.Pow(r, 2); //Calculate area
                Console.WriteLine("Area:" + Area);
            }
            else
            {
                double Circunference = 2* pi * r;
                Console.WriteLine("Circunference:" + Circunference); //Calculate circunference
            }
        }
    }
}