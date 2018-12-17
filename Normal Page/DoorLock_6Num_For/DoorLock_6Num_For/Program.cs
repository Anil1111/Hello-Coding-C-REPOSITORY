﻿using System;

namespace DoorLock_6Num_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] passcodeNumber = { 6, 2, 1, 9, 4, 7 };

            int passcodeLength = 6;
            int[] usrInput = new int[passcodeLength];

            while (true)
            {
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    Console.Write(passcodeIndex);
                    Console.WriteLine("번째 숫자를 넣어주세요.");
                    usrInput[passcodeIndex] = int.Parse(Console.ReadLine());
                }

                bool isPasswordCorrect = true;
                for (int passcodeIndex = 0; passcodeIndex < passcodeLength; passcodeIndex++)
                {
                    if (usrInput[passcodeIndex] != passcodeNumber[passcodeIndex])
                    {
                        isPasswordCorrect = false;
                        Console.WriteLine("비밀번호가 틀렸습니다.");
                        break;
                    }
                }

                if (isPasswordCorrect)
                {
                    Console.WriteLine("문이 열렸습니다.");
                    break;
                }
            }
        }
    }
}
