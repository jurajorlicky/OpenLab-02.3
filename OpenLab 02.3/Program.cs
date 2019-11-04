using System;

namespace OpenLab_02._3
{
    class Program
    {
        public static int Remainder(int a, int b)
        {
            return (a % b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadaj prvé číslo :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadaj druhé číslo :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Výsledok delenia je :");
            Console.WriteLine(Remainder(a, b));

        }
    }
}
