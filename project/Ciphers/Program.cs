using Ciphers;
public class Program {
        static void Main(string[] args){

            if (args.Length < 2){
                throw new ArgumentException("Not enough arguments provided. Please use [KEY] [FILENAME] and optionally [-d]");
            }

            List<string> lines;
            int key = Int32.Parse(args[0]);
            string fileName = args[1];

            if (args.Length == 3 && args[2] == "-d"){
                lines = Caesar.decrypt(key, fileName);
            } else {
                lines = Caesar.encrypt(key, fileName);
            }

            foreach (string line in lines)  {
                Console.WriteLine(line);
            }
        }
}