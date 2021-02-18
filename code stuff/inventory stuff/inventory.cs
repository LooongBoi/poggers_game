using System;
using System.Collections.Generic;

namespace dotnet_test {
    class inventory {
        public List<Potion> Potions = new List<Potion>();
        public List<weapon> Weapons = new List<weapon>();

        public int PotionCount(int recvAmt, string type) {
            int count = 0;
            foreach (Potion potion in Potions) {
                if (potion.type == type) {
                    if (potion.recoverAmount == recvAmt) {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
