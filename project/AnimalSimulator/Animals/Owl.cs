namespace Animals {

    public class Owl : Animal {

        private int kilometersFlown;

        public Owl(string name, int age, AnimalType type) : base(name, age, type){
            kilometersFlown = 0;
        }


        public override void sleep(){
            if (kilometersFlown >= 50){
                base.setSleeping();
            }

        }
        public void fly(int distance){
            kilometersFlown += distance;
        }
    }
}