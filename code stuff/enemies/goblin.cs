using System;

namespace dotnet_test {
    class goblin : enemy {
        public int Potions;


        public goblin(int swordDmg) {
            Weapon = new sword(swordDmg, "Short Sword");
            Health = 60;
            Mana = 100;
            Speed = 4;
            Potions = 3;
            Name = "goblin";
        }

        public override double Block(int incomingDmg)
        {
           return (randnm.Next(0, 50) * incomingDmg)/100; 
        }
    }
}
