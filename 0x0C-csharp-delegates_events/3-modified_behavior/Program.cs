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

    /// Removes health
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine(this.name + " takes 0 damage!");
        }
        else
        {
            Console.WriteLine(this.name + " takes " + damage + " damage!");
            ValidateHP(this.hp -= damage);
        }
    }

    /// Heals the player
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine(this.name + " heals 0 hp!");
        }
        else
        {
            Console.WriteLine(this.name + " heals " + heal + " HP!");
            ValidateHP(this.hp += heal);
        }   
    }

    /// damage and heal delegates
    public delegate void CalculateHealth(float damage);

    /// Validates hp
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }

    /// Applys modifiers
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2f;
        if (modifier == Modifier.Base)
            return baseValue;

        return 1.5f * baseValue;
    }
}

/// Modifier status
public enum Modifier
{
    /// Weak ( .5 )
    Weak,
    /// Base (1)
    Base,
    /// Strong ( 1.5 )
    Strong
}

/// Delegate for modifiers
public delegate float CalculateModifier(float baseValue, Modifier modifier);