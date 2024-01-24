using System;
using System.IO;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Move class Car to the external library.
            //•	Load this external library using reflection (and make all previous steps work again).
            Assembly carAssembly = Assembly.LoadFile(Path.GetFullPath("../../../../CarLib/bin/Debug/netcoreapp3.1/Carlib.dll"));

            Type carType = carAssembly.GetType("CarLib.Car");


            //Write names of all properties, fields and methods of the „Car“
            //Type carType = typeof(Car);

            //foreach(PropertyInfo pi in carType.GetProperties())
            //{
            //    Console.WriteLine(pi.Name);
            //}

            //foreach (FieldInfo fi in carType.GetFields())
            //{
            //    Console.WriteLine(fi.Name);
            //}

            //foreach (MethodInfo mi in carType.GetMethods())
            //{
            //    Console.WriteLine(mi.Name);
            //}


            //•	Create instance of the „Car“ (using reflection).

            //Cach 1:
                object car1 = Activator.CreateInstance(carType);

            //Cach 2:
                object car2 = carType.Assembly.CreateInstance(carType.FullName);

            //Set values of the property Distance and the field Time.
                PropertyInfo distanceProperty = carType.GetProperty("Distance");
                distanceProperty.SetValue(car2, 20.5);

                FieldInfo timeField = carType.GetField("Time");
                timeField.SetValue(car2, 5);


            //•	Call the method „AverageSpeed“, and print result to the console.
            MethodInfo averageSpeedMethod = carType.GetMethod("AverageSpeed");
            Console.WriteLine(averageSpeedMethod.Invoke(car2, new object[0]));

            //•	Call the method „TravelingTime“, and print result to the console.
            MethodInfo travelingTimeMethod = carType.GetMethod("TravelingTime");
            Console.WriteLine(travelingTimeMethod.Invoke(car2, new object[] { 10.3 }));


            Console.WriteLine("Hello World!");
        }
    }
}
