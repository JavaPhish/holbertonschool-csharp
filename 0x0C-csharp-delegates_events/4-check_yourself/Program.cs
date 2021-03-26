using System;


/// Event handling
public class CurrentHPArgs : EventArgs
{
    /// The current hp
    public float currentHp;

    /// Constructor
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }


}

/// Player object
public class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    /// Event handler
    EventHandler<CurrentHPArgs> HPCheck;

    /// Constructor
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        this.status = name + " is ready to go!";
        this.maxHp = maxHp;

        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }

        this.hp = maxHp;

        HPCheck = CheckStatus;
    }

    /// Event listener
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            Console.WriteLine(this.name + " is in perfect health!");
        else if ( e.currentHp >= (this.maxHp / 2))
            Console.WriteLine(this.name + " is doing well!");
        else if ( e.currentHp >= (this.maxHp * .25f) && e.currentHp < (this.maxHp * .5f))
            Console.WriteLine(this.name + " isn't doing too great...");
        else if ( e.currentHp > 0 && e.currentHp < (this.maxHp * .25f))
            Console.WriteLine(this.name + " needs help!");
        else
            Console.WriteLine(this.name + " is knocked out!");
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

        HPCheck(this, new CurrentHPArgs(this.hp));
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