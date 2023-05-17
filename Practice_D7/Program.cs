using System.Data.Common;
using System.Reflection;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.name = "Cati";
            cat.age = 1;
            cat.gender = "Female";
            Console.WriteLine(cat);
            cat.move();
            cat.sound();
            cat.Makesound();

            Dog dog = new Dog();
            dog.name = "Bobby";
            dog.age = 10;
            dog.category = "sheepdog";
            dog.move();
            dog.sound();
            dog.Makesound();

            Eagl eagl = new Eagl();
            eagl.name = "Apollo";
            eagl.age = 10;
            eagl.gender = "American";
            eagl.move();
            eagl.fly();
            dog.Makesound();

            Honda1 honda = new Honda1(1, "honda", "honda", 1777);
            honda.Move();
            honda.Stop();
            Console.WriteLine();

            Caterpillar caterpillar = new Caterpillar(2, "caterpillar", "caterpillar", 1998);
            caterpillar.Move();
            caterpillar.Stop();
            caterpillar.Load();
            caterpillar.Unload();
        }
    }
}
