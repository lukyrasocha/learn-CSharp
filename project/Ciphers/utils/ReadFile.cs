namespace utils{
    public class ReadFile{
        public static string[] ReadAllLines(string fileName){
            string[] lines = System.IO.File.ReadAllLines(fileName);

            return lines;
        }
    }
}