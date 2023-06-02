using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Person
    {
        public int ID;
        public string fName;
        public string lName;
        public int age;
        public bool isMarrid;
        public string job;
        public string address;

        public Person(int iD, string fName, string lName, int age, bool isMarrid, string job, string address)
        {
            this.ID = iD;
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            this.isMarrid = isMarrid;
            this.job = job;
            this.address = address;
        }

        public Person(string fName, string lName, int age, bool isMarrid)
        {
            this.fName = fName;
            this.lName = lName;
            this.age = 0;
            this.isMarrid = isMarrid;
        }

        public void Print()
        {
            Console.WriteLine($"First Name: {fName}");
            Console.WriteLine($"Last Name: {lName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Marrid: {isMarrid}");
            Console.WriteLine($"Jobe: {job}");
            Console.WriteLine($"Adress: {address}");
        }
    }

}
