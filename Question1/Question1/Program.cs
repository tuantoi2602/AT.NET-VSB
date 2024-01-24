using System;

namespace Question1
{
    public class Car
    {
        public string name;

        public int price;
    }
    public class Home
    {
        public string name;

        public int houseNumber;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Test
            Car mycar = new Car() { name = "aaa", price = 1555 };
            Home myhome = new Home() { name = "thec", houseNumber = 15 };

            SimpleXmlSerializer simpleXmlSerializer = new SimpleXmlSerializer();
            simpleXmlSerializer.Serialize(mycar, "car.xml");
            simpleXmlSerializer.Serialize(myhome, "home.xml");
        }
    }
}
