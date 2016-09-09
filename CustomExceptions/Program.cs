using System;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new MyCustomException("My Messgae");
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
    }
}
