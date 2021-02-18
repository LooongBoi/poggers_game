using System;
using System.Linq;

namespace dotnet_test {
    class player {
        public Attributes attributes;
        public inventory Inventory = new inventory();

        public double playerHealth;
        public int playerMana;

        //--------------random num for random block chance
        Random randnm = new Random();
        public player() {
            playerHealth = 100.0;
            playerMana = 75;
        }

        public void takeDamage(int dmgGiven) {
            playerHealth = playerHealth - dmgGiven;
        }
        public int attack(int weaponChoice) {
            return Inventory.Weapons[weaponChoice].damage;
        }
         public double playerblock(int incomingDmg) {
            return (randnm.Next(0, 50) * incomingDmg)/100;
        }
    }
}
