using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Animal
    {
        public string name;
        public int age;
        public virtual void move()
        {
            Console.WriteLine("I'm moving");
        }
        public abstract void Makesound();
    }
    class Cat : Animal
    {
        public string gender;
        public override void move()
        {
            Console.WriteLine("I'm moving by four legs");
        }
        public void sound()
        {
            Console.WriteLine("Niao");
        }
        public override void Makesound()
        {
            Console.WriteLine("Niao");
        }
        public override string ToString()
        {
            return $"my name is {this.name}";
        }
    }
    class Dog : Animal
    {
        public string category;
        public override void move()
        {
            Console.WriteLine("I'm moving by run");
        }
        public void sound()
        {
            Console.WriteLine("Hoho");
        }
        public override void Makesound()
        {
            Console.WriteLine("Hoho");
        }
    }
    sealed class Eagl : Animal
    {
        public string gender;
        public override void move()
        {
            Console.WriteLine("I'm moving by fly");
        }
        public void fly()
        {
            Console.WriteLine("I'm fly");
        }
        public override void Makesound()
        {
            Console.WriteLine("Soo soo");
        }
    }

}
