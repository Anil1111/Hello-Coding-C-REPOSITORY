using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫 번째 숫자를 입력하세요.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요.");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자를 입력하세요.");
            string inputOperator = Console.ReadLine();

            Console.Write(num1);
            Console.Write(inputOperator);
            Console.Write(num2);
            Console.Write(" = ");
            
            if (inputOperator == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else
            {
                if (inputOperator == "-")
                {
                    Console.WriteLine(num1 - num2);
                }

                if (inputOperator == "*")
                {
                    Console.WriteLine(num1 * num2);
                }

                if (inputOperator == "/")
                {
                    Console.WriteLine(num1 / num2);
                }
            }
        }
    }
}
