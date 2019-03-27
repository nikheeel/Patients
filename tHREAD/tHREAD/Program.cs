using System;

namespace Thread
{
    class Program
    {
        static void Main()
        {
            var t = new System.Threading.Thread(Print) {IsBackground = false};
            t.Start();
            
            t.Join();

            var t2 = new System.Threading.Thread(Print2) {IsBackground = false};
            t2.Start();

            for (var i = 0; i < 100; i++)
            {
                Console.Write(0);
            }

            Console.ReadLine();
        }

        private static void Print()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(1);
            }
        }

        private static void Print2()
        {
            for (var i = 0; i < 100; i++)
            {
                Console.Write(2);
            }
        }
    }
}
