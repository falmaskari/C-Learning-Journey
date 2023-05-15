using System.Xml.Serialization;

namespace Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(); //Create object from class

            Console.WriteLine("Enter employee no:");
            int nums = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[nums];
            for (int i = 1; i <= arr.Length; i++)
            {
                Console.WriteLine("Employee"+i);
                Console.WriteLine("First name");
                emp.fName = Console.ReadLine();
                Console.WriteLine("Last name");
                emp.lName = Console.ReadLine();
                Console.WriteLine("Wags");
                emp.wags = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Logged hours");
                emp.loggedHours = Convert.ToInt32(Console.ReadLine());

                double totalSalary = emp.loggedHours * emp.wags; //Calculate total salary
                double taxRate = emp.loggedHours * emp.wags * Employee.TAX; //Calculate tax rate

                double netSalary = totalSalary - taxRate; //Calculate net salary
                Console.WriteLine("Salary:" + netSalary);
                Console.WriteLine();

                int y = 18;
                emp.addone(ref y);
                Console.WriteLine(y);
            }
        }
    }
}
