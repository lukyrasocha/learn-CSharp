namespace Animals{

    public class Kangaroo : Animal  {

        private int jumps;

        public Kangaroo(string name, int age, AnimalType type) : base(name, age, type) {
            jumps = 0;
        }

        public void jump(){
            jumps += 1;
        }

        public override void sleep(){
            if (jumps >= 5){
                base.setSleeping();
            }
        }
    }
}