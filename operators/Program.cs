using System;
using static System.Console;
namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Binary Arithmetic Operators
            int e = 130;
            int f = 13;
            WriteLine($"e is {e} and f is {f}");
            WriteLine($"e + f = {e + f }");
            WriteLine($"e - f = {e - f }");
            WriteLine($"e * f = {e * f }");
            WriteLine($"e / f = {e / f }");
            WriteLine($"e % f = {e % f }");
            #endregion

            #region Assingments Operators
            int p = 6;
            p += 3;
            p -= 3;
            p *= 3;
            p /= 3;
            #endregion

            #region Logical Operators
                bool h = true;
                bool i = false;
                WriteLine($"AND | h | i");
                WriteLine($"h   | {h & h,-5}| {h & i,-5}");
                WriteLine($"i   | {h & h,-5}| {i & i,-5}");

                WriteLine($"OR | h | i");
                WriteLine($"h   | {h | h,-5}| {h | i,-5}");
                WriteLine($"i   | {h | h,-5}| {i | i,-5}");
                
                WriteLine($"XOR | h | i");
                WriteLine($"h   | {h ^ h,-5}| {h ^ i,-5}");
                WriteLine($"i   | {h ^ h,-5}| {i ^ i,-5}");
            #endregion
            #region Conditional Operators
            WriteLine($"h & Do stuff()={h & DoStuff()}");
            WriteLine($"i & Do stuff()={i & DoStuff()}");
            WriteLine($"h & Do stuff()={h && DoStuff()}");
            WriteLine($"i & Do stuff()={i && DoStuff()}");
            #endregion
        }
        private static bool DoStuff(){
            WriteLine("I'm doign stuff...");
            return true;
        }
    }
}
