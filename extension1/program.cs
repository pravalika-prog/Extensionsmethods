using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {

         static void Main(string[] args)
        {
             IPrint printClass=new PrintSomeString();
             // original method
             // printClass.Print("Extension");

            //using extension method
            printClass.PrintExtension("Extension", "Method");

            Console.ReadLine();
        }
    }

    public interface IPrint
    {
        void Print(string str1);
    }

    public class PrintSomeString:IPrint
    {

        public void Print(string str1)
        {
            Console.WriteLine(str1);
        }
    }

    public static class PrintSomethingExtension
    {
        public static void PrintExtension(this IPrint ext, string str1, string str2)
        {
            Console.WriteLine(str1 + " " + str2);
        }
