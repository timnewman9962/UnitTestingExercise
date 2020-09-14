using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }

    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var t1 = word.ToCharArray();
            Array.Reverse(t1);
            return word == new string(t1);
        }
    }

    public class NumFunctions
    {
        public int Add3Ints(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public int Minus(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Ratio(int dividend, int divisor)
        {
            return dividend / divisor;
        }
    }
}
