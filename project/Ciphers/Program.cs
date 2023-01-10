using Ciphers;

public class Program {
        static void Main(string[] args){

            int key = Int32.Parse(args[0]);
            string fileName = args[1];

            Caesar caesar = new Caesar();

            char a = 'a';
            char b = 'b';
            char y = 'y';
            char z = 'z';
            char space = ' ';

            int ia = (int) a;
            int ib = (int) b;
            int iy = (int) y;
            int iz = (int) z;
            int ispace = (int) space;


            Console.WriteLine(ia);
            Console.WriteLine(ib);
            Console.WriteLine(iy);
            Console.WriteLine(iz);
            Console.WriteLine(ispace);

            Console.WriteLine((char) ia);

            string[] lines = caesar.encrypt(key, fileName);
 
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine(line);
            }
        }
}