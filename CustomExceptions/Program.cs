using System;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //throw new MyCustomException("My Messgae");

            PrinitingFinally();
        }


        public void DivisionByZero(int param)
        {
            try
            {
                var result = 10 / param;
            }
            catch (ArgumentException e) when (e.Message =="")
            {

                throw;
            }
        }


        public static void PrinitingFinally()
        {
            try
            {
                string abc = null;
                abc.Split(' ');

            }
            //catch(ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            finally
            {
                Console.WriteLine("finally");
            }
        }
    }
}
