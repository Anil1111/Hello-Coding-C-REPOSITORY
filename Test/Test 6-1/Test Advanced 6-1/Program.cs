using System;

namespace Test_Advanced_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("다음 조건식은 참인가요? 거짓인가요?");

            Console.Write("\"3 <= 5\"은(는) ");
            Console.WriteLine(3 <= 5);

            Console.Write("\"!(5 == 5)\" 은(는) ");
            Console.WriteLine(!(5 == 5));

            Console.Write("\"!(3 < 2)\" 은(는) ");
            Console.WriteLine(!(3 < 2));

            Console.Write("\"1 > 0\" 은(는) ");
            Console.WriteLine(1 > 0);
        }
    }
}
