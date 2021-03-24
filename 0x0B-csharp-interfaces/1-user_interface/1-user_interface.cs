﻿using System;

/// Base class
public abstract class Base
{
    /// The name
    string name
    {
        set;
        get;
    }

    /// ToString override
    public override string ToString()
    {
        return (name + " is a " + this.GetType());
    }
}

/// implements things
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// Test var
    public void Break() {}
    /// Test var
    public void Collect() {}
    /// Test var
    public void Interact() {}
    
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
}

/// Interactive
public interface IInteractive
{
    /// Test func
    void Interact();
}

/// Ibreakble
public interface IBreakable
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
public interface ICollectable
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
