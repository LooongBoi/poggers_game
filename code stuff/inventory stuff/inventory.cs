using System;
using System.Collections.Generic;
using System.Linq;
namespace dotnet_test {
    class inventory {
        public List<Potion> Potions = new List<Potion>();
        public List<weapon> Weapons = new List<weapon>();

        public int PotionCount(string type) {
            int count = 0;
            foreach (Potion potion in Potions) {
                if (potion.type == type) {
                    count++;            
                }
            }
            return count;
        }

        public void displayWeapons() {
            foreach (weapon Weapon in Weapons) {
                Console.WriteLine("\n[ Weapon Inventory ] ");
                Console.WriteLine("{0}) {1} : This weapon does {2} damage :", Weapons.IndexOf(Weapon) + 1, Weapon.name, Weapon.damage);
            }
        }

        public void displayPotions() { 
            // barely makes sense to me but works, adds each type of potion to a seperate list and then calls the PotionCount function to count how many that type there are
            Console.WriteLine("\n[ Potion Inventory ]");
            List<string> typeCount = new List<string>(); 
            foreach (Potion potion in Potions) {
                if (!typeCount.Contains(potion.type)) { // if the type of potion is not in the typeCount the type is added to list as a string
                    typeCount.Add(potion.type);
                }
            }

            foreach (string Type in typeCount) {
                Console.WriteLine("{0}) {1} : {2} :", typeCount.IndexOf(Type) + 1, Type, PotionCount(Type));
            }
        }
    }
}
