using Ciphers;

public class Program {
        static void Main(string[] args){

            int key = Int32.Parse(args[0]);
            string fileName = args[1];

            //List<string> lines = Caesar.encrypt(key, fileName);
            List<string> lines = Caesar.decrypt(key, fileName);
 
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
}