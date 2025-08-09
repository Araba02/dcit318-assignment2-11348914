using System;

namespace InheritanceDemo
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived classes
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===");

            Animal generic = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            generic.MakeSound(); // Output: Some generic sound
            dog.MakeSound();     // Output: Bark
            cat.MakeSound();     // Output: Meow
        }
    }
}

