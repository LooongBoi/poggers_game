using System;

namespace dotnet_test {
    abstract class enemy : entity{
        public string name;
        public int speed;
        public double Resistance;
        public weapon weapon;

        //--------------random num for random block chance
        public Random randnm = new Random();

        public abstract double block(int incomingDmg);

    }
}

