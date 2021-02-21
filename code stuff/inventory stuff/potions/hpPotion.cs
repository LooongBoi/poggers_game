
namespace dotnet_test {
    class hpPotion : Potion{
        public hpPotion(int hpamt, string typ) {
            type = typ;
            recoverAmount = hpamt;
            Class = "health";
        }
    }
}
