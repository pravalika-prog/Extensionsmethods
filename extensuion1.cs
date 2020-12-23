using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    class extensuion1
    {
        public static class StringExtension
        {
            public static int GetWordCount(this string inputstring)
            {
                if (!string.IsNullOrEmpty(inputstring))
                {
                    string[] strArray = inputstring.Split(' ');
                    return strArray.Count();
                }
                else
                {
                    return 0;
                }

            }
        }
        class Program
        {
        static void Main(string[] args)
        {
            string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("string : " + myWord);
            Console.WriteLine("Count : " + wordCount);
            Console.Read();
        }
    }
}
}
