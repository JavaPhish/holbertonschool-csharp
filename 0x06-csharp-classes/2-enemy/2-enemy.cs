using System;

namespace Enemies
{
    /// <summary>
    /// Empty Zombie class
    /// </summary>
    class Zombie
    {
        public int health;

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
    }
}
