using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
			
			 // 呼叫 DisplayWelcomeMessage 函式
            DisplayWelcomeMessage("Alice");

            // 呼叫 AddNumbers 函式並顯示結果
            int result = AddNumbers(5, 10);
            Console.WriteLine($"The sum of 5 and 10 is: {result}");
        }
		
		// 函式 1: 顯示歡迎訊息
        static void DisplayWelcomeMessage(string name)
        {
            Console.WriteLine($"Welcome to the program, {name}!");
        }

        // 函式 2: 計算兩數相加
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}