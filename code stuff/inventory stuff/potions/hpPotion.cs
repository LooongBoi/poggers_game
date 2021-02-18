
namespace dotnet_test {
    class hpPotion : Potion{
        public hpPotion(int hpamt) {
            type = "health";
            recoverAmount = hpamt;
        }
    }
}
