using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIE
{
    class Zombie
    {
        Random rnd = new Random();

        public int health = 50;

        public int attack = 5;

        public int armorClass = 10;

        public int currentRoll = 0;


        public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine("The zombie takes " + damage + " points of damage!");
        }

        public void AttackRoll()
        {
            int roll = rnd.Next(1, 20);
            Console.WriteLine("The zombie rolled a " + roll);
            currentRoll = roll;
        }
    }
}