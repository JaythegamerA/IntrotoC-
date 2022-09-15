using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Jonthan Arzate 2022
//CRPG sect. 3
namespace CRPG
{
    class Program
    {

        private static Player _player = new Player("Abigail", 10, 10, 0, 0, 1, 0);

        static void Main(string[] args)
        {
            GameEngine.Initialize(_player.world);
            _player.MoveTo(World.LocationByID(World.LOCATION_ID_TEMPLE));
            InventoryItem medallion = new InventoryItem(World.ItemByID(World.ITEM_ID_MEDALLION), 1);
            
            //InventoryItem aPass = new InventoryItem(World.ItemByID(World.ITEM_ID_ADVENTURER_PASS), 1);
            _player.Inventory.Add(medallion);
            //_player.Inventory.Add(aPass);
            //Console.WriteLine(RandomNumberGenerator.NumberBetween(4, 10));

            while (true)
            {
                Console.Write("> ");
                string userinput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userinput))
                {
                    continue;
                }
                string cleanedinput = userinput.ToLower();

                if(cleanedinput == "exit")
                {
                    break;
                }
                ParseInput(cleanedinput);

            }//while

        }//main

        public static void ParseInput(string input)
        {
            if (input.Contains("help") || input.Contains("commands") || input.Contains("cmd"))
            {
                Console.WriteLine("Type \"north\", \"east\", \"south\", \"west\", or w, a, s, d to move" +
                    "\nType \"magic\" to use the medallion" +
                    "\nType \"inventory\", \"inv\", i, or e to open inventory" +
                    "\nType \"stats\" to look at your status" +
                    "\nType \"equip\" followed by a weapon" +
                    "\nType \"weapons\" to list all your weapons" +
                    "\nType \"look\" to describe your location" +
                    "\nType \"quests\" to view your quests");
            } else if (input.Contains("what")) 
            {
                Console.WriteLine((_player.world == 1) ? "This world is unfamiliar to you, isn't it, {0}...?" :
                    "You won't last here on your own anymore, {0}...", _player.Name);
            } else if (input.Contains("look"))
            {
                DisplayLocation();
            } else if (input.Contains("north") || input == "w")
            {
                _player.MoveNorth();
            }
            else if (input.Contains("east") || input == "d")
            {
                _player.MoveEast();
            }
            else if (input.Contains("south") || input == "s")
            {
                _player.MoveSouth();
            }
            else if (input.Contains("west") || input == "a")
            {
                _player.MoveWest();
            } else if (input.Contains("magic"))
            {
                _player.SwapWorld();
            } else if (input.Contains("debug"))
            {
                GameEngine.DebugInfo();
            } else if (input.Contains("inv") || input == "e" || input == "i")
            {
                Console.WriteLine("\n\t..::INVENTORY::..");
                foreach (InventoryItem invItem in _player.Inventory)
                {
                    Console.WriteLine("{0} : {1}", invItem.Details.Name, invItem.Quantity);
                }
            } else if (input.Contains("stats"))
            {
                Console.Write($"This is your status. ");
                string detectHealth = (_player.CurrentHitPoints <= _player.MaximumHitPoints / 2) ? $"Are you feeling alright, {_player.Name}?"
                    : $"Don't show weakness now, {_player.Name}.";
                Console.WriteLine(detectHealth);
                Console.WriteLine($"HP: \t{_player.CurrentHitPoints}/{_player.MaximumHitPoints}");
                Console.WriteLine($"XP: \t{_player.ExperiencePoints}");
                Console.WriteLine($"Level: \t{_player.Level}");
                Console.WriteLine($"Gold: \t{_player.Gold}");
            } else if (input == "clear")
            {
                Console.Clear();
            } else if (input == "quests")
            {
                if (_player.Quests.Count == 0)
                {
                    Console.WriteLine("You don't have any quests yet, {0}, you know that.", _player.Name);
                } else
                {
                    foreach (PlayerQuest playerQuest in _player.Quests)
                    {
                        Console.WriteLine("{0} : {1}", playerQuest.Details.Name, playerQuest.IsCompleted ? "Completed" : "Incomplete");
                    }
                }
            }
            else if (input.Contains("attack"))
            {
                if (_player.CurrentLocation.MonsterLivingHere == null)
                {
                    Console.WriteLine((_player.world == 1) ? $"{_player.Name}, you're making a fool of yourself. There are no creatures here to attack. How did you even become the most " +
                        "\npowerful mage in your world if you go about like that?" :
                    $"{_player.Name}, you're making a fool of yourself. There are no creatures here to attack. How did you even become the most " +
                        "\npowerful mage in this world if you go about like that?");
                    Console.WriteLine();
                } else
                {
                    if (_player.CurrentWeapon == null)
                    {
                        Console.WriteLine("You have no weapon to attack with, {0}.", _player.Name);
                    } else
                    {
                        _player.UseWeapon(_player.CurrentWeapon);
                    }
                }
            } else if (input.StartsWith("equip "))
            {
                _player.UpdateWeapons();
                string inputWeaponName = input.Substring(6).Trim();
                if (string.IsNullOrEmpty(inputWeaponName))
                {
                    Console.WriteLine("Come on, {0}, use that little brain of yours. You cannot equip nothing.", _player.Name);
                } else
                {
                    Weapon weaponToEquip = _player.Weapons.SingleOrDefault(x => x.Name.ToLower() == inputWeaponName
                   || x.NamePlural.ToLower() == inputWeaponName);

                    if (weaponToEquip == null)
                    {
                        Console.WriteLine($"You do not have \"{inputWeaponName}\", {_player.Name}. Are you feeling unwell?");
                    } else
                    {
                        _player.CurrentWeapon = weaponToEquip;
                        Console.WriteLine($"You equip your {_player.CurrentWeapon.Name}");
                    }
                }
            } else if (input == "weapons")
            {
                _player.UpdateWeapons();
                Console.WriteLine("List of Weapons:");
                foreach (Weapon w in _player.Weapons)
                {
                    Console.WriteLine($"\t{w.Name}");
                }
            }
            else
            {
                Console.WriteLine("That achieves nothing for you.");
            }
        }//Parse input

        public static void DisplayLocation()
        {
            Console.WriteLine($"\nYou are at {_player.CurrentLocation.Name}.");
            if (_player.CurrentLocation.Description != "")
            {
                Console.Write($"\t{_player.CurrentLocation.Description}\n");
            }
        }
    }
}
