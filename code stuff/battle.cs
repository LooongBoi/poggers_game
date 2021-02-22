using System;

namespace dotnet_test {
    class battle {
        public static void startFight(player player, enemy Enemy) {
            while (true) {
                double dmg; 


                //---------------------- whoever has the larger speed stat attacks first each turn

                if (player.attributes.speed > Enemy.Speed) {
                    
                    //---------------------- calls on the alive check method to make sure theyre alive before next turn starts
            
                    dmg = player.attack(0) - Enemy.Block(player.attack(0));
                    Enemy.Health = Enemy.Health - dmg;

                    if (aliveCheck(player, Enemy) == "enemy defeated") {
                        Console.WriteLine("you did {0} damage to the enemy {1} and it has perished, you have defeated the enemy {2}", dmg, Enemy.Name, Enemy.Name);
                        break;
                    }

                    Console.WriteLine("You dealt {0} damage to the enemy {1}, it has {2} health points remaining", dmg, Enemy.Name, Enemy.Health);

                    dmg = Enemy.Weapon.damage - player.playerblock(Enemy.Weapon.damage);
                    player.Health = player.Health - dmg;

                    if (aliveCheck(player, Enemy) == "game over") {
                        Console.WriteLine("You have died to and enemy {0}", Enemy.Name);
                        break;
                    }

                    Console.WriteLine("The enemy {0} has dealt {1} damage to you. You have {2} health points remaining", Enemy.Name, dmg, player.Health);
                  
                }
                else {

                    //---------------------- check if either player or enemy has died 

                
                    // damage done to player = the damage of enemy weapon - the damage of enemy weapon * random block multiplier
                    dmg = Enemy.Weapon.damage - player.playerblock(Enemy.Weapon.damage);
                    player.Health = player.Health - dmg;

                    if (aliveCheck(player, Enemy) == "game over") {
                        Console.WriteLine("You have died to and enemy {0}", Enemy.Name);
                        break;
                    }

                    Console.WriteLine("The enemy {0} has dealt {1} damage to you. You have {2} health points remaining", Enemy.Name, dmg, player.Health);
                    
                    dmg = player.attack(0) - Enemy.Block(player.attack(0));
                    Enemy.Health = Enemy.Health - dmg;

                    if (aliveCheck(player, Enemy) == "enemy defeated") {
                        Console.WriteLine("you have defeated the enemy {0}", Enemy.Name);
                        break;
                    }

                    Console.WriteLine("You dealt {0} damage to the enemy {1}", dmg, Enemy.Name);


                }
            }
        } 

        public static string aliveCheck(player player, enemy Enemy) {
            if (player.Health <= 0.0) {
                player.Health = 0;
                return "game over";
            }
            else {
                if (Enemy.Health <= 0.0) {
                    Enemy.Health = 0;
                    return "enemy defeated";
                }
                return null;
            } 
        }

        public static string choice(player player) {
            string playerChoice;
            Console.WriteLine("Whay will you do: [Attack] [Check Inventory]");

            playerChoice = Console.ReadLine();

            if (playerChoice == "attack") {
                return playerChoice;
            }

            if (playerChoice == "check") {
                player.Inventory.displayWeapons();
                player.Inventory.displayPotions();
                
                Console.WriteLine("\nWhat will you do: [Take Potion] [Change Weapon]");

                playerChoice = Console.ReadLine();

                if (playerChoice ==  "Take Potion") {
                }

                if (playerChoice == "Change Weapon") {
                }
                return null;
            }
            else {
                return null;
            }
        }
    }
}
