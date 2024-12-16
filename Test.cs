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
			
			// 呼叫 Fun3 函式
            string upperCaseName = Fun3("hello");
            Console.WriteLine($"Fun3: Convert 'hello' to uppercase -> {upperCaseName}");
			
			// 呼叫 Fun4 函式
            bool isEven = Fun4(4);
            Console.WriteLine($"Fun4: Is 4 an even number? -> {isEven}");
			
			// 呼叫 HotFixFunction 函式
            HotFixFunction();
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
		
		// 函式 3: 將字串轉換為大寫
        static string Fun3(string input)
        {
            return input.ToUpper();
        }
		
		// 函式 4: 判斷是否為偶數
        static bool Fun4(int number)
        {
            return number % 2 == 0;
        }
		
		// 函式 5: 模擬修復錯誤的 HotFixFunction
        static void HotFixFunction()
        {
            Console.WriteLine("HotFixFunction: This is a simulated hotfix function to demonstrate patching!");
        }
    }
}