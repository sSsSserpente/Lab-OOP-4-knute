public class LivingOrganism
{
    public int Energy { get; set; }
    public int Age { get; set; }
    public int Size { get; set; }
}

// Inheritance classes: Animal, Plant, Microorganism
public class Animal : LivingOrganism, IReproducible, IPredator
{
    public void Reproduce()
    {
        Console.WriteLine("Animal is reproducing.");
    }

    public void Hunt()
    {
        Console.WriteLine("Animal is hunting.");
    }
}

public class Plant : LivingOrganism, IReproducible
{
    public void Reproduce()
    {
        Console.WriteLine("Plant is reproducing.");
    }
}

public class Microorganism : LivingOrganism, IReproducible
{
    public void Reproduce()
    {
        Console.WriteLine("Microorganism is reproducing.");
    }
}

// Interfaces
public interface IReproducible
{
    void Reproduce();
}

public interface IPredator
{
    void Hunt();
}

// class that models the interaction of organisms
public class Ecosystem
{
    public void Interact(LivingOrganism organism1, LivingOrganism organism2)
    {
        Console.WriteLine($"Interaction between {organism1.GetType().Name} and {organism2.GetType().Name}.");
    }
}