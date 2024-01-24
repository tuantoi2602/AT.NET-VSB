using System;
using System.IO;
using System.Text.Json;
using System.Xml;

namespace FinalAT
{
    public class clsPerson
    {
        public string FirstName;
        public string MI;
        public string LastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsPerson p = new clsPerson();
            p.FirstName = "Jeff";
            p.MI = "A";
            p.LastName = "Price";
            SimpleSerialize s = new SimpleSerialize();
            s.Serialize(p, "xml.xml");
            Console.ReadKey();
        }
    }
}
