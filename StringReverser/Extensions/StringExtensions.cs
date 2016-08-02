using System;
using System.Linq;
using StringReverser.Helpers;

namespace StringReverser.CustomExtensions
{ 

    public static class StringExtensions
    {



        public static string ReverseByLINQ(this String inputString)
        {

            var reversedString = "";

            try
            {
                reversedString = new string(inputString.ToCharArray().Reverse().ToArray());
            }
            catch (Exception exc)
            {
                reversedString = "";
                ExceptionHelper.ProcessException(exc);
            }
            return reversedString;

        }

        public static string ReverseByIteration(this string inputString)
        {

            var reversedString = "";

            try
            {
                for (int position = inputString.Length - 1; position >= 0; position--)
                {
                    reversedString += inputString[position];
                }

            }
            catch (Exception exc)
            {
                reversedString = "";
                ExceptionHelper.ProcessException(exc);
            }
            return reversedString;

        }

        public static string ReverseByArray(this string inputString)
        {

            var reversedString = "";

            try
            {
                char[] inputStringArray = inputString.ToCharArray();
                Array.Reverse(inputStringArray);
                reversedString = new string(inputStringArray);
            }
            catch (Exception exc)
            {
                reversedString = "";
                ExceptionHelper.ProcessException(exc);
            }
            return reversedString;

        }
    }
}

