using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace AlbanianToPhonetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Choose();
            Console.ReadLine();
        }

        public static Dictionary<string, string> AlbanianDictionary()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            // Double letters
            words.Add("SH", "ʃ");
            words.Add("RR", "r");
            words.Add("NJ", "ɲ");
            words.Add("DH", "ð");
            words.Add("GJ", "ɟ");
            words.Add("LL", "ɫ");
            words.Add("ZH", "ʒ");
            words.Add("TH", "θ");
            words.Add("XH", "d͡ʒ");
            //single letters
            words.Add("A", "ä");
            words.Add("B", "b");
            words.Add("C", "t͡s");
            words.Add("Ç", "t͡ʃ");
            words.Add("D", "d");
            words.Add("E", "ɛ");
            words.Add("Ë", "ə");
            words.Add("F", "f");
            words.Add("G", "ɡ");
            words.Add("H", "h");
            words.Add("I", "i");
            words.Add("J", "j");
            words.Add("K", "k");
            words.Add("L", "l");
            words.Add("M", "m");
            words.Add("N", "n");
            words.Add("O", "ɔ");
            words.Add("P", "p");
            words.Add("Q", "c");
            words.Add("R", "ɾ");
            words.Add("S", "s");
            words.Add("T", "t");
            words.Add("U", "u");
            words.Add("V", "v");
            words.Add("X", "d͡z");
            words.Add("Y", "y");
            words.Add("Z", "z");

            return words;
        }
        public static Dictionary<string, string> CzechDictionary()
        {
            Dictionary<string, string> czechwords = new Dictionary<string, string>();
            // Double letters
            czechwords.Add("A", "a");
            czechwords.Add("B", "b");
            czechwords.Add("C", "c");
            czechwords.Add("Ç", "Č ");
            czechwords.Add("D", "d");
            czechwords.Add("E", "e");
            czechwords.Add("F", "f");
            czechwords.Add("G", "g");
            czechwords.Add("Gj", "Ď");
            czechwords.Add("H", "h");
            czechwords.Add("I", "i");
            czechwords.Add("J", "j");
            czechwords.Add("K", "k");
            czechwords.Add("L", "l");
            czechwords.Add("M", "m");
            czechwords.Add("N", "n");
            czechwords.Add("Nj", "ň");
            czechwords.Add("O", "o");
            czechwords.Add("P", "p");
            czechwords.Add("Q", "q");
            czechwords.Add("R", "r");
            czechwords.Add("S", "s");
            czechwords.Add("Sh", "š");
            czechwords.Add("T", "t");
            czechwords.Add("U", "u");
            czechwords.Add("V", "v");
            czechwords.Add("X", "dz");
            czechwords.Add("Xh", "dž");
            czechwords.Add("Y", "y");
            czechwords.Add("Z", "z");
            czechwords.Add("Zh", "ž");


            return czechwords;
        }

        private static void InputWord()
        {
            Console.WriteLine("Please input your word:");
            string albaniansourceword = Console.ReadLine();
            foreach (KeyValuePair<string, string> pair in AlbanianDictionary())
            {
                albaniansourceword = Regex.Replace(albaniansourceword, pair.Key, pair.Value, RegexOptions.IgnoreCase);
            }

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(albaniansourceword);
        }
        private static void TranslateToCzech()
        {
            Console.WriteLine("Please input your word:");
            string czechsourceword = Console.ReadLine();
            foreach (KeyValuePair<string, string> pair in CzechDictionary())
            {
                czechsourceword = Regex.Replace(czechsourceword, pair.Key, pair.Value, RegexOptions.IgnoreCase);
            }

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(czechsourceword);
        }

        public static void Choose()
        {
            Console.WriteLine("Press 1 for Albanian to Phonetics");
            Console.WriteLine("Press 2 for Albanian to Czech");

            int i = Convert.ToInt32(Console.ReadLine());

            if (i == 1)
            {
                InputWord();
                Console.WriteLine("do you want another word inserted? Please type yes/no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Choose();

                }
                else if (answer == "no")
                {
                    Console.WriteLine("Bye!");

                }

            }
            else if (i == 2)
            {
                TranslateToCzech();
                Console.WriteLine("do you want another word inserted? Please type yes/no");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Choose();

                }
                else if (answer == "no")
                {
                    Console.WriteLine("Bye!");

                }
            }


        }
    }
}
