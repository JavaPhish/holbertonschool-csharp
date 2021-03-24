using System;

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
