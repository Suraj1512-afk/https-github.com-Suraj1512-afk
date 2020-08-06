using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;

namespace Practice_Session
{
    class Program
    {


        public abstract class A
        {
            public virtual void func1()
            {
                Console.WriteLine("In parent A");
            }
        }
        public class shape : A
        {
            public override void func1()
            {
                Console.WriteLine("In parent func1");
            }
        }
        public class circle : shape
        {
            static circle()
            {

            }
            public void func1()
            {
                Console.WriteLine("In child func2");
            }
        }

        interface IA
        {
            void Fun(string name);
        }

        interface IB
        {
            void Fun(string name);
        }
        public abstract class AB
        {
            public abstract void Print();
          
            public virtual void Bun()
            {

            }
        }
        public class Employee : AB, IA, IB
        {
            public override void Print()
            {

            }
            public override void Bun()
            {

            }
            public void Fun(string name)
            {
                Console.WriteLine("Print a" + name);
            }
        }

        static void Main(string[] args)
        {
            var w = new WebClient();
            //{
            string url = "https://jsonplaceholder.typicode.com/todos";
            var data = w.DownloadString(url);
            string json = "{\"UserData\":" + data + "}";
            //}
            //WebRequest req = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");
            //req.ContentType = "application/json";
            //WebResponse resp = req.GetResponse();
            //Stream stream = resp.GetResponseStream();
            //StreamReader re = new StreamReader(stream);
            //string json = re.ReadToEnd();
            //json = "{\"UserData\":" + json + "}";
            //UserDTO w = new JavaScriptSerializer().Deserialize<UserDTO>(json);
            //DataContractJsonSerializer datas = new DataContractJsonSerializer(typeof(Root));
            //Root d =  (Root)datas.ReadObject(stream);
           var model = JsonConvert.DeserializeObject<UserDTO>(json);



            //Employee e = new Employee();
            //e.Fun("From Employee");
            //e.Bun();
            //e.Print();

            //IA i1 = new Employee();
            //i1.Fun("from interface 1");

            //IB i2 = new Employee();
            //i2.Fun("FROM interface 2");

            List<string> lst = new List<string>();
            lst.Add("A");
            lst.Add("B");
            lst.Add("C");
            int counter = 1;
            var newString = new StringBuilder();
            foreach(var str in lst)
            {
                newString.Append(str);
                if (lst.Count > counter)
                {
                    newString.Append(", ");
                    counter++;
                }
            }

            Console.WriteLine(newString);


            //try
            //{
            //    int num1 = 0;
            //    int num2 = 1;
            //    var a = num2 / num1;
            //}
            //catch (Exception e)
            //{

            //}
            //finally
            //{
            //    Console.WriteLine("Finally");
            //}
            //Console.WriteLine("testing");


            //StringBuilder str = new StringBuilder();
            //Console.WriteLine(str.GetHashCode());
            //str.Append("Hello");
            //Console.WriteLine(str.GetHashCode());
            //str.Append("  ");
            //Console.WriteLine(str.GetHashCode());
            //str.Append("Builder");
            //Console.WriteLine(str.GetHashCode() + "\n");
            //Console.WriteLine(paramString);
            //Console.WriteLine(str);
            //paramString = str.ToString();
            //Console.WriteLine("Convertted: " + paramString);

            //var name = "Suraj";
            //var name1 = "Anuja";
            //try
            //{
            //    switch (name)
            //    {
            //        case "Suraj":
            //            Console.WriteLine("In 1 st case");
            //            break;
            //        default:
            //            throw new InvalidOperationException("Unexpected value ConfigType = ");
            //    }
            //}
            //catch (Exception ex)
            //{

            //}

            Console.Read();
        }

        private static void Method1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("From method 1: {0}", i);
                if (i == 5)
                    Thread.Sleep(6000);
            }
        }
        private static void Method2()
        {
            for (int i = 11; i <= 20; i++)
            {
                Console.WriteLine("From method 2: {0}", i);
            }
        }

        private void printData<T>(T data)
        {
            Console.WriteLine(data);
        }

        public void TraverseArray<TypeOfValue>(TypeOfValue[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static void TraverseStringArray(string[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        public static void TraverseCharArray(char[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
