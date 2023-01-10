namespace Animals{

    public class Snake : Animal {

        private int lenght;
        private int mouseCount;

        public Snake(string name, int age, AnimalType type, int lenght) : base(name, age, type) {
            this.lenght = lenght;
            mouseCount = 0;
        }

        public void eat() {
            mouseCount += 1;
        }

        
        public override void sleep() {
            if (mouseCount >= 5){
                base.setSleeping();
            }
        }
    }
}