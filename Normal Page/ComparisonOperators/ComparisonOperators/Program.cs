using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("10 > 10 은 ");
            Console.WriteLine(10 > 10);  // False!!!

            Console.Write("10 >= 10 은 ");
            Console.WriteLine(10 >= 10);  // True!!!

            Console.Write("5 <= 10 은 ");
            Console.WriteLine(5 <= 10);  // True!!!

            Console.Write("5 == 4 는 ");
            Console.WriteLine(5 == 4);  // False!!!

            Console.Write("5 != 4 는 ");
            Console.WriteLine(5 != 4);  // True!!!
        }
    }
}
