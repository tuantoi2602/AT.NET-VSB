using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Test2
{
    [Table("Cars")]
    class Car
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    class TableAttribute : Attribute
    {
        public string TableName { get; private set; }
        public TableAttribute(string tableName)
        {
            this.TableName = tableName;
        }
    }
    struct Result
    {
        public string Query;
        public Dictionary<string, object> Parameters;
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            object o = new Car()
            {
                Name = "Honda",
                Price = 13000
            };
            var result = SimpleORM.Insert(o);
            //Console.WriteLine(result.Query);
            Dictionary<string, object> parameters = result.Parameters;

            //foreach (var item in result.Parameters)
            //{
                
            //    Console.WriteLine(item);
                
            //}

        }
    }

    internal class SimpleORM
    {
        public static Result Insert(object obj)
        {
            Result res = new Result();
            Type type = obj.GetType();

            List<string> parameterNames = new List<string>();
            List<string> parameterValues = new List<string>();
            var para = new List<Dictionary<string, object>>();
            var par = new Dictionary<string, object>();
            foreach (PropertyInfo pi in type.GetProperties())
            {
                //if (pi.GetCustomAttributes(typeof(IgnoreInsertAttribute)).Any())
                //{
                //    continue;
                //}


                parameterNames.Add($"[{pi.Name}]");
                parameterValues.Add($"@{pi.Name}");
                
                var para1 = new Dictionary<string, object>();
                if (pi.PropertyType == typeof(string))
                {
                    par.Add($"{pi.Name}", $"{pi.GetValue(obj)?.ToString()}");
                }
                else
                {
                    par.Add($"{pi.Name}", pi.GetValue(obj));
                }
            }

            string tableName = type.Name;
            TableAttribute tableAttr = type.GetCustomAttributes(typeof(TableAttribute)).FirstOrDefault() as TableAttribute;
            if (tableAttr != null)
            {
                tableName = tableAttr.TableName;
            }

            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO [").Append(tableName).Append("] (")
                .AppendJoin(", ", parameterNames)
                .Append(") VALUES (")
                .AppendJoin(", ", parameterValues)
                .Append(")");


            res.Query = sql.ToString();
            res.Parameters = par;
            //res.Parameters = new Dictionary<string, object> { sql.ToString(), object };
            return res;
        }
    }
}
