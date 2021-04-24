using System;

/// Base class
public abstract class Base
{
    /// The name
    public string name;

    /// ToString override
    public override string ToString()
    {
        return ($"{name} is a {this.GetType()}");
    }
}

/// Interactive
interface IInteractive
{
    /// Test func
    void Interact();
}

/// Ibreakble
interface IBreakable
{
    /// Test var
    int durability
    {
        get;
        set;
    }

    /// Test func
    void Break();
}

/// collectable
interface ICollectable
{
    /// Test var
    bool isCollected
    {
        get;
        set;
    }

    /// test func
    void Collect();
}

/// Door class
public class Door : Base, IInteractive
{
    /// Constructer
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// interaction
    public void Interact()
    {
        Console.WriteLine("You try to open the " + this.name + ". It's locked.");
    }
}

/// A decoration object
public class Decoration : Base, IInteractive, IBreakable
{
    /// durability of decoration object
    public int durability
    {
        get;
        set;
    }

    /// Is quest item?
    public bool isQuestItem;

    /// Constructor
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability < 1)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// Interact with decorations
    public void Interact()
    {
        if (durability < 1)
            Console.WriteLine("The " + name + " has been broken.");
        else if (isQuestItem)
            Console.WriteLine("You look at the " + name + ". There's a key inside.");
        else
            Console.WriteLine("You look at the " + name + ". Not much to see here.");
    }

    /// Break the decoration
    public void Break()
    {
        durability -= 1;

        if (durability > 0)
            Console.WriteLine("You hit the " + name + ". It cracks.");
        else if (durability == 0)
            Console.WriteLine("You smash the " + name + ". What a mess.");
        else
            Console.WriteLine("The " + name + " is already broken.");
    }
}
