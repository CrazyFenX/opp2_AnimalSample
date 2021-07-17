using System;

namespace opp1_AnimalSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal cat = new Animal("Pushok", 2.3f, 'b');
            ////cat.color = 'w';
            ////cat.name = "pushok";
            ////cat.mass = 2.3f;
            //cat.say();

            Cat cat = new Cat("Pushok", 2.3f, 'b', 0.4f);
            Dog dog = new Dog("Sharik", 5.2f, 'g');

            cat.say();
            Console.WriteLine();
            dog.say();
        }
    }
}
