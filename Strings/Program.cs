using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {


        const int xCon = 10;

        readonly int rOnly;

        public Program()
        {
            
            rOnly = 40;
        }
        

        static void Main(string[] args)
        {
            #region Others
            //String s1, s2;

            //s1 = "Hi";
            //s2 = "Hello";

            //Console.WriteLine($"{s1} and {s2} and {s1}");

            //Console.WriteLine($"{s1.GetHashCode()} and {s2.GetHashCode()}");

            //int[] xArr = new int[] {10,20,30,40,50,60,70,80};

            //int[] yArr = xArr.OrderByDescending(x => x).Select(x => x).ToArray();

            //int? z = null;

            //int y = z ?? 10;

            //Console.WriteLine(y);

            //Hashtable table = new Hashtable();
            //table.Add(1,"Value");
            //table.ContainsKey(1);


            ////Array.Copy(xArr,0, yArr, 0, 8);

            //for (int i = 0; i < yArr.Length; i++)
            //{                
            //    Console.WriteLine(yArr[i]);
            //}

            //BubbleSort();

            #endregion


            //SplitingTheStringBasedonNumber();

            //VowelCountFromAString();

            CountingTheRepetingCharectersInAWord();


        }

        static void VowelCountFromAString()
        {
            string str = "HelothisisAstring";

            int count = 0;

            str = str.ToLower();

            //int vowelCount = str.Count(c => c.Equals('a') || c.Equals('e') || c.Equals('i') || c.Equals('o') || c.Equals('u'));


            char[] strArray = str.ToCharArray();

            foreach (var charr in strArray)
            {
                if (charr.Equals('a') || charr.Equals('e') || charr.Equals('i') || charr.Equals('o') || charr.Equals('u'))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            //Console.WriteLine(vowelCount);
        }

        private static void SplitingTheStringBasedonNumber()
        {
            string str = "A string is an object of type String whose value is text. Internally, the text is stored as a sequential read-only collection of Char objects. There is no null-terminating character at the end of a C# string";

            MatchCollection strGroups = Regex.Matches(str, ".{10}?");

            Console.WriteLine(strGroups[0]);

        }

        private static void BubbleSort()
        {
            int[] sortArray = new int[] { 10, 15, 18, 13, 89, 56, 47, 78, 85, 12, 46, 58 };

            bool flag = true;


            int temp = 0;

            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = i+1; j < sortArray.Length; j++)
                {
                    if (sortArray[i] > sortArray[j])
                    {
                        temp = sortArray[i];
                        sortArray[i] = sortArray[j];
                        sortArray[j] = temp;                        
                    }
                }
            }

            foreach (var item in sortArray)
            {
                Console.WriteLine(item);
            }

        }

        private static void RepetativeNumberInArray()
        {
            int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 4, 4, 4, 5, 6, 4, 7, 7, 7, 4, 5, 4, 5, 1, 4 };

            Console.WriteLine(numArray.Count(x => x == 4)); 
        }

        private static void CountingTheRepetingCharectersInAWord()
        {
            string str = "GAABBBCCCCCCCDDDDDDEEEEEEEFGGGGGGGGGGGGG";

            Dictionary<char, int> sdict = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (!sdict.ContainsKey(item))
                {
                    sdict.Add(item, 1);
                }
                else
                {
                    sdict[item]++;
                }
            }

            foreach (var item in sdict)
            {
                Console.WriteLine($"Char is {item.Key} and its count is {item.Value}");
            }        


        }

        

        private static void CountingTheRepetingWords()
        {
            string str = "Hi in this word there are so so many word and word literals";

            string[] newStr = str.Split(' ');

            Dictionary<string, int> newDict = newStr.GroupBy(x => x).ToDictionary(x => x.Key, y => y.Count());

            foreach (var item in newDict)
            {
                Console.WriteLine(item.Key +  " : " + item.Value);
            }
        }

        private static void SplitTheString()
        {
            string str = "abc gef";

            string[] newstr = str.Split(' ');
            Console.WriteLine(newstr[0]);
        }

        private static void FindingPrimeNumbers()
        {
            
                        
            for (int item = 2; item < 100; item ++)
            {                

                int flag = 0;

                int x = item / 2;

                for (int i = 2; i <= x; i++)
                {
                    if (item % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }

        private static void SumofEvenNumbersinanArray()
        {
            int count = 0;

            int[] inArray = new int[] {10,20,50,13,46,78,146,68,45,285,789,526,87,9469,79,97,97,46,8,7,94};

            for (int i = 0; i < inArray.Length; i++)
            {
                if (inArray[i] % 2 == 0)
                {
                    count += inArray[i];
                }
            }

            Console.WriteLine(count);

            Console.WriteLine(inArray.Where(x => x % 2 == 0).Select(x => x).Sum());

        }

        private static void CheckingTheStringWeatherItContainsNumericOrNot()
        {
            string str = "34";

            int i = 0;

            if (int.TryParse(str,out i))
            {
                Console.WriteLine("Convertible" + i);
            }
            else
            {
                Console.WriteLine("Not convertable");
            }
        }

        private static void ReverseTheOrderOfWords()
        {
            string str = "Hi this is a new word that is going to be reversed.";

            string[] strArray = str.Split(' ');

            //foreach (var item in strArray)
            //{
            //    Console.Write(String.Join(" ",item.Reverse().ToArray())); 
            //}

            Array.Reverse(strArray);

            Console.WriteLine(string.Join(" ", strArray));


        }

        // With String Function
        public static void StringReverse()
        {
            string str = "My Name is Sreenivas";

            Console.WriteLine(str.Reverse().ToArray());                        
        }

        //WithOut String Function and using string builder
        public static void StringReverseWithoutFunction()
        {
            string str = "My Name is Sreenivas";

            StringBuilder sb = new StringBuilder();

            Char[] chArray = str.ToCharArray();

            for (int i = chArray.Length -1; i >= 0; i--)
            {
                sb.Append(chArray[i]);                
            }

            Console.WriteLine(sb.ToString());
            
        }

        public static void ReverseofStringWithOutFunction()
        {
            string str = "My Name is Sreenivas";
            //Console.WriteLine(new string(Enumerable.Range(1, str.Length).Select(x => str[str.Length - x]).ToArray()));

            //Console.WriteLine(new string(str.Select((c, index) => new { c, index }).OrderByDescending(x => x.index).Select(x => x.c).ToArray()));  

            char[] chArray = str.ToArray();

            char[] newChArray = new char[str.Length];

            for (int i = 0; i < chArray.Length; i++)
            {
                newChArray[(str.Length - 1) - i] = chArray[i];
            }

            foreach (var item in newChArray)
            {
                Console.Write(item);
            }
        }

        
        
    }

    
}
