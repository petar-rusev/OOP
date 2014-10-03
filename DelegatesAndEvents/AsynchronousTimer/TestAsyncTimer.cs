namespace AsynchronousTimer
{
    using System;
    using System.Threading;

    class TestAsyncTimer
    {
        public static void Main(string[] args)
        {
            AsyncTimer at = new AsyncTimer(RespondMethod, 1000, 20);
            AsyncTimer at2 = new AsyncTimer(SecondMethod, 1000, 20);

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main program action!");
                Thread.Sleep(100);
            }
        }

        public static void RespondMethod()
        {
            Console.WriteLine("Test Print!");
        }

        public static void SecondMethod()
        {
            Console.WriteLine("Second subscriber!");
        }
    }
}
