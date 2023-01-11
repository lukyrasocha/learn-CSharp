using utils;

namespace Ciphers {
    public class Caesar {
        public static List<string> encrypt(int key, string fileName){
            string[] plainLines = ReadFile.ReadAllLines(fileName);
            List<string> encryptedLines = new List<string>(); 

            foreach (string line in plainLines){
                char[] chars = line.ToCharArray();

                for (int i = 0; i < chars.Length; i++){
                    char character = chars[i];
                    if (char.IsLetter(character)){
                        int offset = char.IsUpper(character) ? 'A' : 'a';   // Make the range 1-26 (like an alphabet)
                        character = (char)((character + key - offset) % 26 + offset);
                    }
                    chars[i] = character; // Write the encrypted character back
                }

                encryptedLines.Add(new string(chars));
            }

            return encryptedLines;
        }

        public static List<string> decrypt(int key, string fileName){
            string[] encryptedLines = ReadFile.ReadAllLines(fileName);
            List<string> decryptedLines = new List<string>(); 

            foreach (string line in encryptedLines){
                char[] chars = line.ToCharArray();

                for (int i = 0; i < chars.Length; i++){
                    char character = chars[i];
                    if (char.IsLetter(character)){
                        int offset = char.IsUpper(character) ? 'A' : 'a'; // Make the range 1-26 (like in an alphabet)
                        character = (char)(((character - key - offset) + 26) % 26 + offset);
                    }
                    chars[i] = character; // Write the decrypted character back

                }

                decryptedLines.Add(new string(chars));
            }

            return decryptedLines;
        }
    }
}