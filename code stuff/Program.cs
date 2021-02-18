using System;
using System.Collections.Generic;


namespace dotnet_test
{
    class Program
    {
        static void Main(string[] args)
        {

            player Player = new player();
            hpPotion sHealthPotion = new hpPotion(10);
            hpPotion mHealthPotion = new hpPotion(20);
            hpPotion lHealthPotion = new hpPotion (40);

            //------------------------------testing adding potions to inventory
            
            //Player.Inventory.Potions.Add(sHealthPotion);

            //Console.WriteLine(Player.Inventory.hpPotionCount(10));

            //------------------------------testing playing with player attributes
            //int x;

            //Console.WriteLine("please enter your strength points");
            //x = int.Parse(Console.ReadLine());
            //Player.attributes.strength = x;
            //Console.WriteLine(Player.attributes.strength);

            //------------------------------testing player damage and attack

            Console.WriteLine(Player.playerHealth);

            sword LongSword = new sword(30);

            Player.Inventory.Weapons.Add(LongSword);



            //------------------------------testing battles 

            goblin mGoblin = new goblin(20);
            Player.attributes.speed = 5;
            Player.attributes.resistance = 20;

            battle.startFight(Player, mGoblin);
            // alex is a doodoo head
        }
    }
}
