using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp_var;
            temp_var = Console.ReadLine();
            //Used extension method here to check given number is valid or not/
            if(temp_var.IsNumber())
            {
                Console.WriteLine(temp_var +" :is a valid number.");
            }
            else
            {
                Console.WriteLine("NaN");
            }
            Console.ReadKey();
        }
     
    }
    
    static class Extension
    {
       public static bool IsNumber(this string number)
            // Parameter with always with "this" keyword, and the type always the one for which you want that function to use.
        {
            double temp_var;
            return double.TryParse(number, out temp_var);
        }

    }
