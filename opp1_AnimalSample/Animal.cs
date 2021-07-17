using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp1_AnimalSample
{
    public class Animal
    {
        //поля
        public string name;    //кличка
        public float mass = 0; //вес
        public char color;     //цвет
    
        //конструкторы
        public Animal() { }
        public Animal(string name1, float mass1, char color1)
        {
            name = name1;
            mass = mass1;
            color = color1;
        }
        public Animal(string name, float mass)
        {
            this.name = name;
            this.mass = mass;
        }

        //методы
        public virtual void say()
        {
            Console.WriteLine($"{name} ({color}, {mass}) says:");
            Console.WriteLine("Abstract voice"); //издать абстрактный звук
        }
    }

    class Cat : Animal
    {
        //Поля
        public float lengthTail;

        //Конструкторы
        //public Cat(string name1, float mass1, char color1, float lengthTail1)
        //{
        //    name = name1;
        //    mass = mass1;
        //    color = color1;
        //    lengthTail = lengthTail1;
        //}

        public Cat(string name1, float mass1, char color1, float lengthTail1) : base(name1, mass1, color1)
        {
            lengthTail = lengthTail1;
        }

        //методы
        public override void say()
        {
            Console.WriteLine($"{name} ({color}, {mass}, {lengthTail}) says:");
            Console.WriteLine("meow"); //издать звук meow
        }
    }

    class Dog : Animal
    {
        //Конструкторы
        public Dog(string name1, float mass1, char color1) : base(name1, mass1, color1) { }

        //Методы
        public override void say()
        {
            Console.WriteLine($"{name} ({color}, {mass}) says:");
            Console.WriteLine("wof"); //издать звук wof
        }
    }
}
