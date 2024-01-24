using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ThreadAT
{
    class Async
    {
        static async Task Main(string[] args)
        {
            long val = await Experiment();


            Console.WriteLine(val);
        }

        public static async Task<long> Experiment()
        {
            Console.WriteLine("Start");
            await Task.Delay(1000);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            using (StreamWriter sw = new StreamWriter("test.txt"))
            {
                await sw.WriteLineAsync("Hello World!");
            }
            stopWatch.Stop();
            await Task.Delay(1000);

            Console.WriteLine("End");

            return stopWatch.ElapsedMilliseconds;
        }
    }
}
