using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            //object lockObject = new object();

            //void Execute()
            //{
            //    Random rand = new Random();

            //    while (true)
            //    {
            //        if(rand.NextDouble() < 0.6)
            //        {
            //            lock (lockObject)
            //            {
            //                if (!myStack.IsEmpty)
            //                {
            //                    myStack.Pop();
            //                }
            //            }
            //        }
            //        else
            //        {
            //            myStack.Push(rand.Next());
            //        }
            //    }
            //}
            //List<Thread> threads = new List<Thread>();
            //for(int i = 0; i<5; i++)
            //{
            //    Thread t = new Thread(Execute);
            //    t.Start();
            //    threads.Add(t);
            //}

            //foreach(Thread t in threads)
            //{
            //    t.Join();
            //}



            //Synchronization
            //1.	Start one thread, which will use the already prepared stack - add one randomly generated value into it, every 100ms.
            Thread t1 = new Thread(() =>
            {
                Random rand = new Random();
                while (true)
                {
                    myStack.Push(rand.Next());
                    Thread.Sleep(100);
                }
            });
            t1.Start();

            object lockObject = new object();
            for(int i = 0; i < 5; i++)
            {
                Thread t2 = new Thread(() => {
                    while (true)
                    {
                        int value;
                        lock (lockObject)
                        {
                            if (myStack.IsEmpty)
                            {
                                continue;
                            }
                            value = myStack.Pop();
                        }
                        
                        Console.WriteLine(value + " | TID: " + Thread.CurrentThread.ManagedThreadId);
                    }
                });
                t2.Start();
            }
            t1.Join();
        }
    }
}
