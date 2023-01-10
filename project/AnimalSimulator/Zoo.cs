using Animals;

namespace Zoo {

    public class Zoo{
        private List<Animal> animals = new List<Animal>();

        public void addAnimal(Animal animal){
            animals.Add(animal);
        }

        public List<Animal> getAnimals(){
            return animals;
        }

        static void Main(string[] args){
            Console.WriteLine("Welcome to our Zoo");

            Zoo FrederiksbergZoo = new Zoo();

            Animal bob = new Snake("Bob", 3, AnimalType.Reptile, 132);
            Animal rob = new Snake("Rob", 1, AnimalType.Reptile, 251);

            Animal jake = new Kangaroo("Jake", 5, AnimalType.Mammal);
            Animal jimmy = new Kangaroo("Jimmy", 6, AnimalType.Mammal);

            Animal lisa = new Owl("Lisa", 7, AnimalType.Bird);
            Animal sophie = new Owl("Sophie", 10, AnimalType.Bird);

            FrederiksbergZoo.addAnimal(bob);
            FrederiksbergZoo.addAnimal(rob);
            FrederiksbergZoo.addAnimal(jake);
            FrederiksbergZoo.addAnimal(jimmy);
            FrederiksbergZoo.addAnimal(lisa);
            FrederiksbergZoo.addAnimal(sophie);

            foreach(Animal animal in FrederiksbergZoo.getAnimals()){

                if (animal is Kangaroo){
                    Kangaroo kangaroo = (Kangaroo) animal;
                    kangaroo.jump();
                }

                if (animal is Owl){
                    Owl owl = (Owl) animal;
                    owl.fly(100);
                }

                if (animal is Snake){
                    Snake snake = (Snake) animal;
                    snake.eat();
                }

                animal.sleep();

                Console.WriteLine(animal.getName() + " " + animal.getAnimalType());

            }
        }
    }
}