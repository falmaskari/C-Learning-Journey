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


        public Vehicle(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
    interface IDriveable
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
    class Honda1 : Vehicle, IDriveable
    {
        public int yearOfManufacturer;
        public Honda1(int id, string name, string description, int yearOfManufacturer) : base(id, name, description)
        {
            this.yearOfManufacturer = yearOfManufacturer;
        }
        public void Move()
        {
            Console.WriteLine("Move");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
    class Caterpillar : Vehicle, IDriveable, ILoader
    {
        public int yearOfManufacturer;
        public Caterpillar(int id, string name, string description, int yearOfManufacturer) : base(id, name, description)
        {
            this.yearOfManufacturer = yearOfManufacturer;
        }
        public void Move()
        {
            Console.WriteLine("Move");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void Load()
        {
            Console.WriteLine("Load");
        }
        public void Unload()
        {
            Console.WriteLine("Unload");
        }
    }

}
