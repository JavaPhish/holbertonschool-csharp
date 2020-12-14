using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public Dog(string Name, float Age, string Owner, Rating rating1)
    {
        name = Name;
        age = Age;
        owner = Owner;
        rating = rating1;
    }

    public string name { get; }
    public float age { get; }
    public string owner { get; }
    public Rating rating { get; }
}
