namespace AIE
{
    class Slayer
    {
        Random rnd = new Random();

        public int health = 20;

        public int attack = 5;

        public int armorClass = 15;

        public int currentRoll = 0;

        public bool isDodging = false;


        public void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine("You take " + damage + " points of damage!");
            Console.WriteLine("You have " + health + " points of health remaining!");
        }

        public void AttackRoll()
        {
            int roll = rnd.Next(1, 20);
            currentRoll = roll;
        }

        public void Heal()
        {
            int amount = rnd.Next(2, 7);
            Console.WriteLine("You regain " + amount + " hitpoints!");
            health += amount;
            Console.WriteLine("You now have " + health + " hitpoints!");
        }
    }
}