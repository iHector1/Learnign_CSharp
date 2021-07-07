using System;
using static System.Console;
namespace formatPrint
{
    class Program
    {
        static void Main(string[] args)
        {
           Tuple <string,string,string,string>[] tipo={
                Tuple.Create("sbyte|",$"{sizeof(sbyte)}|",$"{sbyte.MinValue}|",$"{sbyte.MaxValue}|"),
                Tuple.Create("byte|",$"{sizeof(byte)}|",$"{byte.MinValue}|",$"{byte.MaxValue}|"),
                Tuple.Create("short|",$"{sizeof(short)}|",$"{short.MinValue}|",$"{short.MaxValue}|"),
                Tuple.Create("ushort|",$"{sizeof(ushort)}|",$"{ushort.MinValue}|",$"{ushort.MaxValue}|"),
                Tuple.Create("int|",$"{sizeof(int)}|",$"{int.MinValue}|",$"{int.MaxValue}|"),
                Tuple.Create("uint|",$"{sizeof(uint)}|",$"{uint.MinValue}|",$"{uint.MaxValue}|"),
                Tuple.Create("long|",$"{sizeof(long)}|",$"{long.MinValue}|",$"{long.MaxValue}|"),
                Tuple.Create("float|",$"{sizeof(float)}|",$"{float.MinValue}|",$"{float.MaxValue}|"),
                Tuple.Create("double|",$"{sizeof(double)}|",$"{double.MinValue}|",$"{double.MaxValue}|"),
                Tuple.Create("decimal|",$"{sizeof(decimal)}|",$"{decimal.MinValue}|",$"{decimal.MaxValue}|")
            };
            Console.WriteLine(("").PadRight(93, '_'));
            WriteLine(String.Format("{0,10}{1,18}{2,33}{3,33}","Type|","Byte(s) of memory|","Min|","Max|"));
            Console.WriteLine(("").PadRight(93, '_'));
            foreach (var tipos in tipo)
            {
                var result=String.Format("{0,10}{1,18}{2,33}{3,33}",tipos.Item1,tipos.Item2,tipos.Item3,tipos.Item4);
                WriteLine(result);
            }
            Console.WriteLine(("").PadRight(93, '_'));
        }
    }
}
