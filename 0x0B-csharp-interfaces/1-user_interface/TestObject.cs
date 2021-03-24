using System;
using System.Collections.Generic;
using System.Reflection;


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