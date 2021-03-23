using System;

/// <summary>
/// Base queue
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Returns the type of the current queue
    /// </summary>
    public Type CheckType() {
        return (typeof(T));
    }
}
