using System;
using System.Collections.Generic;


namespace dotnet_test
{
    class Program
    {
        static void Main(string[] args)
        {

            player Player = new player();
            hpPotion sHealthPotion = new hpPotion(10, "small");
            hpPotion mHealthPotion = new hpPotion(20, "medium");
            hpPotion lHealthPotion = new hpPotion (40, "large");

            //------------------------------ testing adding potions to inventory
            
            Player.Inventory.Potions.Add(sHealthPotion);
            Player.Inventory.Potions.Add(sHealthPotion);
            Player.Inventory.Potions.Add(mHealthPotion);
            Player.Inventory.Potions.Add(mHealthPotion);
            Player.Inventory.Potions.Add(lHealthPotion);
            Player.Inventory.Potions.Add(lHealthPotion);
            Player.Inventory.Potions.Add(mHealthPotion); 
            Player.Inventory.Potions.Add(mHealthPotion);


            //Console.WriteLine(Player.Inventory.hpPotionCount(10));
            //------------------------------ testing playing with player attributes
            //int x;

            //Console.WriteLine("please enter your strength points");
            //x = int.Parse(Console.ReadLine());
            //Player.attributes.strength = x;
            //Console.WriteLine(Player.attributes.strength);

            //------------------------------ testing player damage and attack

            Console.WriteLine(Player.Health);

            sword LongSword = new sword(30, "Long Sword");

            Player.Inventory.Weapons.Add(LongSword);



            //------------------------------ testing battles 

            goblin mGoblin = new goblin(20);
            Player.attributes.speed = 5;
            Player.attributes.resistance = 20;

            battle.startFight(Player, mGoblin);

            Player.Inventory.displayWeapons();


            Player.Inventory.displayPotions();
        }
    }
}
