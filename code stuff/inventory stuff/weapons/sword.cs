
namespace dotnet_test {
    class sword : weapon {
        public sword(int wpDmg, string nm) {
            type = "melee";
            damage = wpDmg;
            name = nm;
        }
    }
}
