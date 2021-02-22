using System;
using System.Linq;

namespace dotnet_test {
    class player : entity{
        public Attributes attributes;
        public inventory Inventory = new inventory();

        //-------------- random num for random block chance
        Random randnm = new Random();
        public player() {
            Health = 100.0;
            Mana = 75;
        }
        
        public void takeDamage(int dmgGiven) {
            Health = Health - dmgGiven;
        }
        public int attack(int weaponChoice) {
            return Inventory.Weapons[weaponChoice].damage;
        }
         public double playerblock(int incomingDmg) {
            return (randnm.Next(0, 50) * incomingDmg)/100;
        }

        public void takePotion() {
            
        }
    }
}
