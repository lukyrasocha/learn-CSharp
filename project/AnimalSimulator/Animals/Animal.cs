namespace Animals{

    public abstract class Animal {

        private string name;
        private int age;
        private AnimalType type; 
        private Boolean sleeping;

        public Animal(string name, int age, AnimalType type){
            this.name = name;
            this.age = age;
            this.type = type;
        }
        
        public int getAge(){
            return age;
        }

        public string getName(){
            return name;
        }

        public AnimalType getAnimalType(){
            return type;
        }

        public Boolean getSleepingStatus(){
            return sleeping;
        }

        public void setSleeping(){
            sleeping = true;
        }

        public abstract void sleep();
    }
}