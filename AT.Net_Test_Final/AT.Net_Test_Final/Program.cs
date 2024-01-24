using System;
using System.IO;
using System.Reflection;

namespace AT.Net_Test_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly myAssembly;
            myAssembly = Assembly.LoadFile(Path.GetFullPath("C:/Users/Goal/Downloads/UnknownLibrary.dll"));

            foreach(Type type in myAssembly.GetTypes())
            {
                Console.WriteLine(type.Name);
            }

            Console.WriteLine("\n");

            Type myType = myAssembly.GetType("UnknownLibrary.BmiCalculator");

            foreach (MethodInfo mf in myType.GetMethods())
            {
                Console.WriteLine(mf);
                foreach (ParameterInfo pi in mf.GetParameters())
                {
                    Console.WriteLine(pi);
                }
            }
            Console.WriteLine("\n");
            foreach (PropertyInfo pi in myType.GetProperties())
            {
                Console.WriteLine(pi.Name);
            }
            
            //Creating instance of Car using reflection
            object myRef = Activator.CreateInstance(myType);

            MethodInfo setHeight = myType.GetMethod("set_Height");
            Console.WriteLine(setHeight.Invoke(myRef, new object[] {70} ));

            MethodInfo setMass = myType.GetMethod("set_Mass");
            Console.WriteLine(setHeight.Invoke(myRef, new object[]{50} ));

            MethodInfo averageSpeed = myType.GetMethod("Calculate");
            Console.WriteLine(averageSpeed.Invoke(myRef, new object[0]));
            

        }
    }
}
