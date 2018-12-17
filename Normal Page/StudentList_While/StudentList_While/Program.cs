using System;

namespace StudentList_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("학생 숫자를 입력하세요.");
            int sC = int.Parse(Console.ReadLine());

            int[] ages = new int[sC];
            string[] names = new string[sC];
            double[] heights = new double[sC];

            int sN = 0;
            while (sN<sC)
            {
                Console.Write(sN + 1);
                Console.WriteLine("번째 학생의 정보를 입력할 차례입니다.");

                Console.WriteLine("나이를 입력하세요.");
                ages[sN] = int.Parse(Console.ReadLine());

                Console.WriteLine("이름을 입력하세요.");
                names[sN] = Console.ReadLine();

                Console.WriteLine("키를 입력하세요.");
                heights[sN] = double.Parse(Console.ReadLine());

                sN += 1;
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("입력된 학생정보를 출력할 차례입니다.");
            sN = 0;
            while (sN < sC)
            {
                Console.Write(sN);
                Console.WriteLine(" 번째 학생");
                Console.Write("이름 = ");
                Console.WriteLine(names[sN]);
                Console.WriteLine("키 = ");
                Console.WriteLine(heights[sN]);

                sN += 1;
            }
        }
    }
}
