using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearningLINQ
{
    public static class ExtensionMethods
    {
        public static double ToDouble(string textThatConvertToDouble)
        {
            return double.Parse(textThatConvertToDouble);
        }

        public static Double ToDoubleExt(this string textThatConvertToDouble)
        {
            return double.Parse(textThatConvertToDouble);

        }

        public static bool IsZipCodeValid(string zipCode)
        {
            return zipCode.Length == 5 || zipCode.Length == 9;
        }

        public static bool IsZipCodeValidExt(this string zipcode)
        {
            return zipcode.Length == 5 || zipcode.Length == 9;
        }       
                  
    }
}
