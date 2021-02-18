using System;

namespace dotnet_test {
    class goblin : enemy {
        public int enemyPotions;


        public goblin(int swordDmg) {
            enemyWeapon = new sword(swordDmg);
            enemyHealth = 60;
            enemySpeed = 4;
            enemyPotions = 3;
            enemyName = "goblin";
        }

        public override double enemyBlock(int incomingDmg)
        {
           return (randnm.Next(0, 50) * incomingDmg)/100; 
        }
    }
}
