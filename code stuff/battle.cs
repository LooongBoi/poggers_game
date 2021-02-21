using System;

namespace dotnet_test {
    class battle {
        public static void startFight(player player, enemy Enemy) {
            while (true) {
                double dmg; 


                //----------------------whoever has the larger speed stat attacks first each turn

                if (player.attributes.speed > Enemy.enemySpeed) {
                    
                    //---------------------- calls on the alive check method to make sure theyre alive before next turn starts
                    if (aliveCheck(player, Enemy) == "game over") {
                        Console.WriteLine("You have died to and enemy {0}", Enemy.enemyName);
                        break;
                    }

                    if (aliveCheck(player, Enemy) == "enemy defeated") {
                        Console.WriteLine("you have defeated the enemy {0}", Enemy.enemyName);
                        break;
                    }

                    dmg = player.attack(0) - Enemy.enemyBlock(player.attack(0));
                    Enemy.enemyHealth = Enemy.enemyHealth - dmg;

                    Console.WriteLine("You dealt {0} damage to the enemy {1}", dmg, Enemy.enemyName);

                    dmg = Enemy.enemyWeapon.damage - player.playerblock(Enemy.enemyWeapon.damage);
                    player.playerHealth = player.playerHealth - dmg;

                    Console.WriteLine("The enemy {0} has dealt {1} damage to you. You have {2} health points remaining", Enemy.enemyName, dmg, player.playerHealth);
                  
                }
                else {

                    if (aliveCheck(player, Enemy) == "game over") {
                        Console.WriteLine("You have died to and enemy {0}", Enemy.enemyName);
                        break;
                    }

                    if (aliveCheck(player, Enemy) == "enemy defeated") {
                        Console.WriteLine("you have defeated the enemy {0}", Enemy.enemyName);
                    }

                
                    // damage done to player = the damage of enemy weapon - the damage of enemy weapon * random block multiplier
                    dmg = Enemy.enemyWeapon.damage - player.playerblock(Enemy.enemyWeapon.damage);
                    player.playerHealth = player.playerHealth - dmg;

                    Console.WriteLine("The enemy {0} has dealt {1} damage to you. You have {2} health points remaining", Enemy.enemyName, dmg, player.playerHealth);
                    
                    dmg = player.attack(0) - Enemy.enemyBlock(player.attack(0));
                    Enemy.enemyHealth = Enemy.enemyHealth - dmg;

                    Console.WriteLine("You dealt {0} damage to the enemy {1}", dmg, Enemy.enemyName);

                    
                    //----------------------check if either player or enemy has died 

                }
            }
        } 

        public static string aliveCheck(player player, enemy Enemy) {
            if (player.playerHealth <= 0.0) {
                player.playerHealth = 0;
                return "game over";
            }
            else {
                if (Enemy.enemyHealth <= 0.0) {
                    Enemy.enemyHealth = 0;
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
            }
            else {
                return null;
            }
        }
    }
}

