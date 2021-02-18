using System;

namespace dotnet_test {
    abstract class enemy {
        public double enemyHealth;
        public string enemyName;
        public int enemySpeed;
        public double enemyResistance;
        public weapon enemyWeapon;

        //--------------random num for random block chance
        public Random randnm = new Random();

        public abstract double enemyBlock(int incomingDmg);

    }
}

