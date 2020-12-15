using System;

namespace Enemies
{
    /// <summary>
    /// Empty Zombie class
    /// </summary>
    class Zombie
    {
        public int health;
        string name = "(No name)";

        /// <summary>
        /// Sets the health of the zombie to 0 (Constructor)
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Sets the health of the zombie to value (Public Constructor)
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// toString Override
        /// </summary>
        /// <returns>
        /// Returns the string rep of this class
        /// </returns>
        public override string ToString()
        {
            return $"Zombie name: {name} / Total Health: {health}";
        }

        /// <summary>
        /// Health property
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the zombies health (Getter)
        /// </summary>
        /// <returns>
        /// The zombies current health
        /// </returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
