namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(); //Create an instance from class
            cat.name = "LuluCati";
            cat.age = 1;
            cat.gender = "Female";
            Console.WriteLine(cat);
            cat.move();
            cat.sound();
            cat.Makesound();

            Dog dog = new Dog();
            dog.name = "Bobby";
            dog.age = 3;
            dog.category = "Domestic";
            dog.move();
            dog.sound();
            dog.Makesound();

            Eagl eagl = new Eagl();
            eagl.name = "Apollo";
            eagl.age = 10;
            eagl.gender = "Male";
            eagl.move();
            eagl.fly();
            dog.Makesound();

            Honda honda = new Honda(1, "Honda", "First class", 1881);
            honda.Move();
            honda.Stop();

            Cterpillar cterpillar = new Cterpillar(1, "Honda", "First class", 1881);
            cterpillar.Move();
            cterpillar.Stop();
            cterpillar.Load();
            cterpillar.Unload();
        }
    }
}