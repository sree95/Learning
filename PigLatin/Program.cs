using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PigLatin
{
    class Program
    {
        static string str = "Alex, how did you do question 21?";

        static void Main(string[] args)
        {
            string[] strArray = str.Split(' ');
            string latestSubString;

            foreach (var subString in strArray)
            {
                if (Regex.IsMatch(subString,""))
                {

                }

                int d;
                 
                if (int.TryParse(subString, out d))
                {
                    latestSubString = subString;
                }
                else
                {
                    char fLetter = subString[0];
                    string secondString = subString.Remove(0, 1);
                    char lLetter = subString[subString.Length - 1];

                    if (lLetter.Equals('a') || lLetter.Equals('A'))
                    {
                        latestSubString =  secondString + fLetter + "y";
                    }
                    else
                    {
                        latestSubString = secondString + fLetter + "ay";
                    }
                }

                Console.WriteLine(latestSubString);
            }
        }
    }
}
