using System;

namespace Intro_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;


            Console.Write("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("\nEnter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"\nAdding {a} + {b} equals {Addnumbers(a,b)}");
        }

        public static int Addnumbers(int a, int b)
        {
            //Modificanco la funcion Addnumbers para que retorne una resta
            return a - b;
        }
    }
}