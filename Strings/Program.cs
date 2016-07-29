using System;
using System.Collections;
using System.Linq;
using System.Text;
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
            
            String s1, s2;

            s1 = "Hi";
            s2 = "Hello";

            Console.WriteLine($"{s1} and {s2} and {s1}");

            Console.WriteLine($"{s1.GetHashCode()} and {s2.GetHashCode()}");

            int[] xArr = new int[] {10,20,30,40,50,60,70,80};

            int[] yArr = xArr.OrderByDescending(x => x).Select(x => x).ToArray();

            int? z = null;

            int y = z ?? 10;

            Console.WriteLine(y);

            Hashtable table = new Hashtable();
            table.Add(1,"Value");
            table.ContainsKey(1);


            //Array.Copy(xArr,0, yArr, 0, 8);

            for (int i = 0; i < yArr.Length; i++)
            {                
                Console.WriteLine(yArr[i]);
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
