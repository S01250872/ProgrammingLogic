// Step 1 – Base class
public class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Step 2 – Derived class: Cat
public class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

// Step 2 – Derived class: Dog
public class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

// Step 3 – Main method
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        myAnimal.animalSound();  // Output: The animal makes a sound
        myCat.animalSound();     // Output: The cat says: meow
        myDog.animalSound();     // Output: The dog says: bow wow
    }
}