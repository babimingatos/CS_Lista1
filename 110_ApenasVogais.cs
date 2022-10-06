        
class alfabeto
    {
        static bool isAlphabet(char ch)
        {
            if (ch >= 'a' && ch <= 'z')
                return true;
            if (ch >= 'A' && ch <= 'Z')
                return true;

            return false;
        }

        static string remConsonants(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u',
                      'A', 'E', 'I', 'O', 'U' };

            string sb = "";
            
            for (int i = 0; i < str.Length; i++)
            {
                bool present = false;
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (str[i] == vowels[j])
                    {
                        present = true;
                        break;
                    }
                }

                if (!isAlphabet(str[i]) || present)
                {
                    sb += str[i];
                }
            }
            return sb;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase: ");
            string str =Console.ReadLine();

            Console.Write(remConsonants(str));
        }
    }
