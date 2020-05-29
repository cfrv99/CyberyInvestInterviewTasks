using System;

namespace CybernetTasks
{
    class Program
    {
        static int p1 = 0, p2 = 1, p3;

        static void Main(string[] args)
        {
            Console.WriteLine("Cybernet Exam!");

            #region Fibonacci
            //Console.WriteLine(p1+ " " + p2);
            //FiboRecursive(5);
            //Fibo(5);
            #endregion

            #region Factorial
            //int num = Convert.ToInt32(Console.ReadLine());
            //int result = Fact(num);
            //Console.WriteLine("Factorial Result:" + result);
            #endregion

            #region RecursiveFact
            //int num = Convert.ToInt32(Console.ReadLine());
            //int resultRecursive = RecursiveFact(num);
            //Console.WriteLine("Recursive Factorial Result:" + resultRecursive);
            #endregion

            #region Reverse
            int num = Convert.ToInt32(Console.ReadLine());
            int result = ReverseIntegerNumber(num);
            Console.WriteLine("Reversing Number: " + result);
            #endregion
        }
        public static void FiboRecursive(int count)
        {
            if (count > 0)
            {
                p3 = p1 + p2;
                Console.WriteLine(" " + p3);
                p1 = p2;
                p2 = p3;
                FiboRecursive(count - 1);
            }
        }
        public static void Fibo(int count)
        {

            for (int i = 2; i < count; i++)
            {
                p3 = p1 + p2;
                Console.WriteLine(" " + p3);
                p1 = p2;
                p2 = p3;
            }
            Console.WriteLine();
        }
        public static int RecursiveFact(int num)
        {
            int factResult = 1;
            if (num > 0)
            {
                factResult = num * RecursiveFact(num - 1);
            }
            return factResult;
        }
        public static int Fact(int num)
        {
            int factResult = 1;
            for (int i = 1; i <= num; i++)
            {
                factResult = factResult * i;
            }
            return factResult;
        }
        public static int ReverseIntegerNumber(int num)
        {
            int reverseResult = 0;
            int remainder;

            while (num != 0)
            {
                remainder = num % 10;
                reverseResult = reverseResult * 10 + remainder;
                num /= 10;
            }
            return reverseResult;

        }
    }
}
