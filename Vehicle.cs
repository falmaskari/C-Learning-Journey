using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public int id;
        public string name;
        public string description;

        public Vehicle(int id, string name, string description) //Create constructor
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
    interface IDriveable //Create interface
    {
        void Move();
        void Stop();
    }
    interface ILoader
    {
        void Load();
        void Unload();
    }
    class Honda : Vehicle, IDriveable
    {
        public int yearOfManufacturer;
        public Honda(int id, string name, string description, int yearOfManufacturer) : base(id, name, description)
        {
            this.yearOfManufacturer = yearOfManufacturer;
        }
        public void Move()
        {
            Console.WriteLine("I move");
        }
        public void Stop()
        {
            Console.WriteLine("I stop");
        }
    }
    class Cterpillar : Vehicle, IDriveable, ILoader
        {
            public int yearOfManufacturer;
            public Cterpillar(int id, string name, string description, int yearOfManufacturer) : base(id, name, description)
            {
                this.yearOfManufacturer = yearOfManufacturer;
            }

            public void Load()
            {
                Console.WriteLine("I load");
            }

            public void Move()
            {
                Console.WriteLine("I move");
            }

            public void Stop()
            {
                Console.WriteLine("I stop");
            }

            public void Unload()
            {
                Console.WriteLine("I unload");
            }
        }
}
