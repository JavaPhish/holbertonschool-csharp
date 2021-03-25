using System;


/// Player object
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// Constructor
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        this.maxHp = maxHp;

        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.hp = maxHp;
    }

    /// Prints the players health
    public void PrintHealth()
    {
        Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }
}