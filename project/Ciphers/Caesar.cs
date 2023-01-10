using utils;

namespace Ciphers {

    public class Caesar {

        public string[] encrypt(int key, string fileName){
            string[] plainLines = ReadFile.ReadAllLines(fileName);
            string[] encryptedLines = new string[plainLines.Length];

            foreach (string line in plainLines){
                string encryptedLine = "";
                foreach(char character in line){
                    if (character != ' '){
                        int charCode = (int) character - 96;                  // To get a range 1-26 as in the alphabet;
                        int encryptedCharCode = ((charCode + key) % 26) + 96; 

                        encryptedLine += (char) encryptedCharCode;

                    } else{
                        encryptedLine += ' ';
                    }

                }

                encryptedLines.Append(encryptedLine);
            }
            return encryptedLines;
        }

        public string[] decrypt(int key, string fileName){
            string[] encryptedLines = ReadFile.ReadAllLines(fileName);
            string[] decryptedLines = new string[encryptedLines.Length];

            foreach (string line in encryptedLines){
                string decryptedLine = "";
                foreach(char character in line){
                    if (character != ' '){
                        int charCode = (int) character - 96; // To get a range 1-26 as in an alphabet;
                        int encryptedCharCode = (charCode - key) % 26; 

                        decryptedLine += (char) encryptedCharCode;

                    } else{
                        decryptedLine += ' ';
                    }

                }

                decryptedLines.Append(decryptedLine);
            }
            return decryptedLines;
        }

    }
}