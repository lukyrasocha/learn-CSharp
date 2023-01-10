using System.Collections;

namespace basicsyntax {
    class MyClass {
        public void func(){
            Console.WriteLine("I have been imported!");
        }

        public int add(int a, int b) {
            return a + b;
        }

        public void testSyntax() {

            // If statements
            int x = 5;
            if (x == 5) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }

            // Static arrays
            int[] intArray = new int[5];
            intArray[0] = 12;
            
            // Dynamic arrays
            ArrayList dynamicArray = new ArrayList();
            dynamicArray.Add("HELLO");
            dynamicArray.Add("WORLD");
            Console.WriteLine(dynamicArray[0]);

            List<int> dynamicArrayWithGenerics = new List<int>();
            dynamicArrayWithGenerics.Add(50);
            Console.WriteLine(dynamicArrayWithGenerics[0]);

            // HashTable
            Hashtable dictionary = new Hashtable();
            dictionary.Add(1, "value1");
            dictionary.Add(2, "value2");

            // While loop
            string text = "NOTHELLO";
            while(text != "HELLO"){
                text = "HELLO";
            }

            // For loop
            for(int i = 0; i < 10; i ++){
                Console.WriteLine("Iteration: " + i);
            }

            // Foreach loop
            foreach(string t in dynamicArray){
                Console.WriteLine(t);
            }

        }
    }
}