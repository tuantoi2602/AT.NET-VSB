using System;
using System.Diagnostics;
using System.IO;

namespace Diagnostics
{
    class Program
    {
        class MyOwnFileTraceListener : TraceListener
        {
            public override void Write(string message)
            {
                using (FileStream fs = new FileStream("mylog.txt", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using(StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(DateTime.Now.ToString());
                        sw.Write(message);
                    }
                }
            }

            public override void WriteLine(string message)
            {
                using (FileStream fs = new FileStream("mylog.txt", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(DateTime.Now.ToString());
                        sw.Write(message);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
           
            Trace.Listeners.Add(new MyOwnFileTraceListener());
            Trace.WriteLine("My losxaxsasasasasa ");
            Debug.Fail("Something wrong");
        }
    }
}
