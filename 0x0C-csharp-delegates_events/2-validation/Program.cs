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
            this.hp -= damage;
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
            this.hp += heal;
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
}