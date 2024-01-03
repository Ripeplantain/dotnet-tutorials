using System;
using System.Threading;


namespace ThreadDelegate
{

    public delegate void SumOfNumbersCallback(int SumOfNumbers);

    class Program
    {

        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum of numbers = " + sum);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter target number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);

            Number number = new Number(target);
            Thread T1 = new Thread(number.PrintSumOfNumbers);
            T1.Start();
        }
    }


    class Number
    {

        private int _target;
        SumOfNumbersCallback _callbackMethod;

        public Number(int target, SumOfNumbersCallback callbackMethod)
        {
            this._target = target;
            this._callbackMethod = callbackMethod;
        }

        public void PrintSumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum = sum + i;
            }

            if(_callbackMethod != null)
                _callbackMethod(sum);
        }
    }
}