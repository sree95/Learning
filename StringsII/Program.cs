using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsII
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //StringReversal();

            //CountingNumberOfCharacters();

            //NumberOfWordsInAString();

            //RepetingWordsInACharacter();

            CountPerticularChar();
        }

        private static void CountPerticularChar()
        {
            string str = "AAAAAAAAAAAAAAABBBBBBBBBBBCCCCCCCCCCCCCDDDDDDDDDDD";


            Console.WriteLine(str.Count(x => x == 'A'));
        }

        private static void NumberOfWordsInAString()
        {
            string str = "Hello This is a new string and it contains latest strings";

            string[] strArray = str.Split(' ');

            var cou = strArray.Select(x => new {
                Word = x,
                Count = x.Count()
            });

            foreach (var item in cou)
            {
                Console.WriteLine(item.Word);
                Console.WriteLine(item.Count);
            }
        }

        private static void RepetingWordsInACharacter()
        {
            string str = "Hi Hi Hello I am an Hi Hi Sreenivas";

            string[] strArray = str.Split(' ');

            Dictionary<string,int> wordDist = new Dictionary<string, int>();

            foreach (var item in strArray)
            {
                if (!wordDist.ContainsKey(item))
                {
                    wordDist.Add(item,1);
                }
                else
                {
                    wordDist[item]++;
                }
            }

            foreach (var item in wordDist)
            {
                Console.WriteLine($"{item.Key} and {item.Value}");
            }
        }

        private static void CountingNumberOfCharacters()
        {
            string str = "Hello How are you, I am good";

            // To get a particular character count
            //Console.WriteLine(str.Count(x => x == 'h'));

            // TO get all characters

            Dictionary<char, int> charcount = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (!charcount.ContainsKey(item))
                {
                    charcount.Add(item, 1);
                    
                }
                else
                {
                    charcount[item]++;
                }
            }

            foreach (var item in charcount)
            {
                Console.WriteLine($"Key is: {item.Key} and its iterations are: {item.Value}");
            }

        }

        private static void StringReversal()
        {
            string str = "Hello I am Sreenivas";

            //Solution 1            

            //foreach (var item in str.Reverse())
            //{
            //    Console.Write(item);
            //}

            //Solution 2

            StringBuilder sb = new StringBuilder();

            for (int i = str.Length-1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            Console.WriteLine(sb.ToString());
        }


    }
}
