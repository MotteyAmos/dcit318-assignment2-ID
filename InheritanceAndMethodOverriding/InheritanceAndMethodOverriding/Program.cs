

namespace InheritanceAndMethodOverriding
{
    //base class
    public class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Some generic Sound");
        }
    }

    public class Dog: Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Bark");
        }

    }

    public class Cat: Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            animal.makeSound();
            dog.makeSound();
            cat.makeSound();
        }
    }
}