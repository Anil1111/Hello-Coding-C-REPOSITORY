using System;

namespace DoorLock_6Num_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumbers = { 6, 2, 1, 9, 4, 7 };
            int[] usrInput = new int[6];

            while (true)
            {
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

                if (usrInput[0] == passcodeNumbers[0] && usrInput[1] == passcodeNumbers[1] && usrInput[2] == passcodeNumbers[2] && usrInput[3] == passcodeNumbers[3] && usrInput[4] == passcodeNumbers[4] && usrInput[5] == passcodeNumbers[5])
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("비밀번호가 틀렸습니다.");
                }
            }
            
        }
    }
}
