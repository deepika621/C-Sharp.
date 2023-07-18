using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Animal
    {
        public string Name;
        public int Age;
        public Animal(string name, int age) {
            Name = name;
            Age = age;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("This animal makes a sound");
        }
    }
    class Dog : Animal
    {
        public string Breed;
        public Dog(string name,int age,string breed):base(name, age)
        {
            Breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine("The Dog Barks");
        }
    }
    class Program1
    {
        public static void Usinginheritance()
        {
            Animal myAnimal = new Animal("Bob", 5);
            Dog MyDog = new Dog("Snoopy", 3,"Labrador");
            Console.WriteLine($"My Animal is a {myAnimal.Age}-year-old{myAnimal.Name}.");
            myAnimal.MakeSound();
            Console.WriteLine($"My Dog is a {MyDog.Age}-year-old{MyDog.Breed} named {MyDog.Name}");
            MyDog.MakeSound();
        }
    }
}
