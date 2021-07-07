using System;
using static System.Console;
namespace binaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;
            WriteLine($"a={a}");
            WriteLine($"b={b}");
            WriteLine($"a & b ={a & b}");
            WriteLine($"a & b ={a & b}");
            WriteLine($"a | b ={a | b}");
            WriteLine($"a ^ b ={a ^ b}");


            #region Byinary shift
            WriteLine($"a<<3={a<<3}");
            WriteLine($"a*8 ={a * 8}");
            WriteLine($"b>>1={b >> 1}");
            #endregion

            int age = 47;
           // char fistDigit = age.ToString();
        }
    }
}