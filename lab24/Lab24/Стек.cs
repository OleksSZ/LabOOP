using System;
using System.Collections.Generic;

namespace Lab22
{
    public class MyStack
    {
        private Stack<int> stack = new Stack<int>();

        // 1. Виведення масиву у зворотному порядку
        public static void PrintArrayReverse(int[] arr)
        {
            var stack = new Stack<int>(arr);
            Console.WriteLine("Масив у зворотному порядку:");
            foreach (var item in stack)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        // 2. Виведення слова у зворотному порядку
        public static void PrintWordReverse(string word)
        {
            var stack = new Stack<char>(word);
            Console.WriteLine("Слово у зворотному порядку:");
            foreach (var ch in stack)
                Console.Write(ch);
            Console.WriteLine();
        }
    }
}
