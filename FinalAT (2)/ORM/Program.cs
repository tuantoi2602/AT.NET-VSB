using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ORM
{
    class TableAttribute : Attribute
    {
        public string TableName { get; private set; }
        public TableAttribute(string tableName)
        {
            this.TableName = tableName;
        }
    }
    class IgnoreInsertAttribute : Attribute
    {

    }
    class Person
    {

        public string Name { get; set; }
        [IgnoreInsert]
        public int Age { get; set; }
    }

    [Table("Vehicals")]
    class Car
    {
        public string Color { get; set; }
        public int Speed { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string sql = CreateInsert(new Person()
            {
                Name = "Jan",
                Age = 32
            });
            Console.WriteLine(sql);

            sql = CreateInsert(new Car()
            {
                Color = "Red",
                Speed = 100
            });
            Console.WriteLine(sql);
        }
        public static string CreateInsert(object obj)
        {
            Type type = obj.GetType();

            List<string> parameterNames = new List<string>();
            List<string> parameterValues = new List<string>();

            foreach(PropertyInfo pi in type.GetProperties())
            {
                if (pi.GetCustomAttributes(typeof(IgnoreInsertAttribute)).Any())
                {
                    continue;
                }


                parameterNames.Add($"[{pi.Name}]");
                string value = pi.GetValue(obj)?.ToString();
                if(pi.PropertyType == typeof(string))
                {
                    parameterValues.Add($"\"{value}\"");
                }
                else
                {
                    parameterValues.Add(value);
                }
            }

            string tableName = type.Name;
            TableAttribute tableAttr = type.GetCustomAttributes(typeof(TableAttribute)).FirstOrDefault() as TableAttribute;
            if(tableAttr != null)
            {
                tableName = tableAttr.TableName;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO [").Append(tableName).Append("] (")
                .AppendJoin(", ", parameterNames)
                .Append(") VALUES (")
                .AppendJoin(", ", parameterValues)
                .Append(")");



            return sql.ToString();
        }
    }
}
