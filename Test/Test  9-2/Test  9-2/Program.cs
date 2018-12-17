using System;

namespace Test__9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            int totalScoreSum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1);
                Console.WriteLine("번째 과목의 성적을 입력하세요.");
                scores[i] = int.Parse(Console.ReadLine());
                totalScoreSum += scores[i];
            }

            Console.Write("총점은 ");
            Console.Write("\"" + totalScoreSum + "\"");
            Console.WriteLine("점입니다.");
        }
    }
}
