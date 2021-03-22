using System;

/// <summary>
/// Base queue
/// </summary>
public class Queue<T>
{
    public Type CheckType() {
        return (typeof(T));
    }
}
