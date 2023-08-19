namespace main;

internal static class Program
{
    private static void Main()
    {
        Animal[] animals =
        {
            new Dog(), new Cat()
        };
        PrintAnimalSounds(animals);
    }

    static void PrintAnimalSounds(Animal[] animals)
    {
        foreach (Animal animal in animals)
        {
            Console.WriteLine("This animal makes: " + animal.MakeSound());
        }
    }
}

public abstract class Animal
{
    public abstract string MakeSound();
}

public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof!";
    }
}

public class Cat : Animal
{
    public override string MakeSound()
    {
        return "Meow!";
    }
}