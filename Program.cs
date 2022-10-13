using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace ThreadDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            var sp = new Stopwatch();
            sp.Start();
            var thread = new Thread(() => Increment());

            thread.Start();

            WriteLine("\n");
            var thread2 = new Thread(() => Decrement());
            thread2.Start();

            thread.Join();
            sp.Stop();

            WriteLine("Geçen süre: " + sp.Elapsed.Seconds);
            ReadKey();
        }

        static void Increment()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(500);
                WriteLine("Number: " + i.ToString());
            }
        }
        static void Decrement()
        {
            for (int j = 10; j >= 0; j--)
            {
                Thread.Sleep(500);
                WriteLine("Number: " + j.ToString());
            }
        }
    }
}