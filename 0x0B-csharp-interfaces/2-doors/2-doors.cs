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

/// implements things
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// Test var
    public void Interact() {}
    /// Test var
    public void Break() {}
    /// Test var
    public void Collect() {}

    
    /// Test func
    public int durability
    {
        get;
        set;
    }

    /// Test func
    public bool isCollected
    {
        get;
        set;
    }

    /// test name
    public string name
    {
        get;
        set;
    }
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