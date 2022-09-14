using System;

namespace AIE
{

    class Program
    {
        static void Main()
        {
            Slayer player = new Slayer();
            Zombie enemy = new Zombie();
            Party team = new Party();

            Console.WriteLine("You are ambushed by a zombie!!!");

            while (player.health > 0 || enemy.health > 0)
            {
                for (int i = 0; i < team.partyMembers.Length; i++)
                {
                    Console.WriteLine("Your turn! What's your action?");
                    Console.WriteLine("You may attack, dodge, heal, or flee!");

                    string playerAction = Console.ReadLine();

                    if (playerAction == "attack")
                    {
                        player.AttackRoll();
                        Console.WriteLine("You rolled a " + player.currentRoll);

                        if (player.currentRoll >= enemy.armorClass)
                        {
                            if (player.currentRoll < 20)
                            {
                                Console.WriteLine("You hit!");
                                enemy.TakeDamage(player.attack);
                            }
                            else
                            {
                                Console.WriteLine("CRITICAL HIT!!!");
                                enemy.TakeDamage(player.attack * 2);
                            }

                            Console.WriteLine("The zombie has " + enemy.health + " hitpoints remaining");
                        }
                        else
                        {
                            if (player.currentRoll == 1)
                            {
                                Console.WriteLine("CRITICAL MISS!!!");
                            }
                            else
                            {
                                Console.WriteLine("You missed");
                            }
                        }
                    }
                    else if (playerAction == "dodge")
                    {
                        player.isDodging = true;
                    }

                    else if (playerAction == "heal")
                    {
                        player.Heal();
                    }

                    else if (playerAction == "flee")
                    {
                        Console.WriteLine("You flee from the zombie...you coward.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("You decide to make a typo as an action!");
                    }
                }
                Console.WriteLine("");

                //ZOMBIE'S TURN
                Console.WriteLine("The zombie begins its turn!");
                Console.WriteLine("The zombie attacks!");
                enemy.AttackRoll();

                if (enemy.currentRoll >= player.armorClass)
                {
                    if (enemy.currentRoll == 20)
                    {
                        Console.WriteLine("CRITICAL HIT!!!");
                        player.TakeDamage(enemy.attack * 2);
                        if (player.isDodging == true)
                        {
                            player.isDodging = false;
                        }
                    }
                    else
                    {
                        if (player.isDodging == false)
                        {
                            Console.WriteLine("The zombie hits you!");
                            player.TakeDamage(enemy.attack);
                        }
                        else
                        {
                            player.isDodging = false;
                            Console.WriteLine("The zombie hits you, but you manage to negate some damage by dodging.");
                            player.TakeDamage(enemy.attack / 2);
                        }
                    }
                }
                else
                {
                    if (enemy.currentRoll == 1)
                    {
                        Console.WriteLine("CRITICAL MISS!!!");
                    }
                    else
                    {
                        Console.WriteLine("The zombie misses");
                    }
                }

                Console.WriteLine("");


                if (player.health <= 0)
                {
                    Console.WriteLine("You died");
                    break;
                }
                else if (enemy.health <= 0)
                {
                    Console.WriteLine("You've defeated the zombie!");
                    break;
                }
            }

        }
    }
}