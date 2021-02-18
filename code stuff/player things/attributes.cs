using System;

namespace dotnet_test
{
    struct Attributes
    {
        public Attributes(int mp) {
            max_points = mp;
            strength = 0;
            speed = 0;
            agility = 0;
            endurance = 0;
            stealth = 0;
            perception = 0;
            luck = 0;
            dexterity = 0;
            intelligence = 0;
            vitality = 0;
            resistance = 0.0;
        }
        public int strength;
        public double resistance;
        public int speed;
        public int agility;
        public int endurance;
        public int stealth;
        public int perception;
        public int luck;
        public int dexterity;
        public int intelligence;
        public int vitality;
        public int max_points;

        public bool checkSumOver() {
            if (strength + speed + agility + endurance + stealth + perception + luck + dexterity + intelligence + vitality < max_points) {
                return false;
            } else return true;
        }
    }
}
