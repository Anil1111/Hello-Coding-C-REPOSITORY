using System;

namespace DoorLock_6Num
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] psNum = { 6, 2, 1, 9, 4, 7 };
            int[] usrInput = new int[6];

            Console.WriteLine("첫 번째 숫자를 넣어주세요.");
            usrInput[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 넣어주세요.");
            usrInput[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("세 번째 숫자를 넣어주세요.");
            usrInput[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("네 번째 숫자를 넣어주세요.");
            usrInput[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("다섯 번째 숫자를 넣어주세요.");
            usrInput[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("여섯 번째 숫자를 넣어주세요.");
            usrInput[5] = int.Parse(Console.ReadLine());

            if (usrInput[1] == psNum[1] && usrInput[2] == psNum[2] && usrInput[3] == psNum[3] && usrInput[4] == psNum[4] && usrInput[5] == usrInput[5] && usrInput[0] == usrInput[0])
            {
                Console.WriteLine("문이 열렸습니다.");
            }
            else
            {
                Console.WriteLine("비밀번호가 틀렸습니다.");
            }
        }
    }
}
