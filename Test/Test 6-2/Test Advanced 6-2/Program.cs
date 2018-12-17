using System;

namespace Test_Advanced_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("먹은 사과의 개수를 입력하세요.");
            int eatenAppleCount = int.Parse(Console.ReadLine());
            if (eatenAppleCount > 3)
            {
                Console.WriteLine("사과를 많이 먹었습니다.");
            }
            else if (eatenAppleCount < 3)
            {
                Console.WriteLine("사과를 조금 먹었습니다.");
            }
            else
            {
                Console.WriteLine("사과를 적절히 먹었습니다.");
            }
        }
    }
}
