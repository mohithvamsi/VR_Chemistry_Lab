using System;

class Liquid
{
    public string Name { get; set; }
    public double Volume { get; set; } // Volume in milliliters

    public Liquid(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }

    public void Pour(Liquid destination, double amount)
    {
        if (amount > Volume)
        {
            Console.WriteLine($"Not enough {Name} to pour.");
            return;
        }

        Volume -= amount;
        destination.Volume += amount;

        Console.WriteLine($"{amount} mL of {Name} poured. Remaining: {Volume} mL");
        Console.WriteLine($"Destination now has {destination.Volume} mL of {destination.Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Liquid water = new Liquid("Water", 500); // 500 mL of water
        Liquid beaker = new Liquid("Empty Beaker", 0); // Empty beaker

        water.Pour(beaker, 200); // Pour 200 mL from water to beaker
        water.Pour(beaker, 350); // Attempt to pour more than remaining volume
    }
}