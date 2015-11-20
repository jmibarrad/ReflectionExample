using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;
            //a = "";
            var x = 1;
            //x = "";
            object y = "";
            y = 2;
            //int z = y + 1;
            dynamic b = "";
            b = 1;
            int z = b + 1;
            Console.WriteLine(z);
            Console.WriteLine(suma("hola","ing"));
            Console.WriteLine(suma(2000, 42));
            Console.WriteLine(Funct(new MyClass()));
            dynamic arr = new dynamic[3];
            arr[0] = 1;
            arr[1] = 2.46;
            arr[2] = new MyClass();
            Console.WriteLine(suma(arr[0] + arr[1], arr[2].getValue()));
            Console.ReadKey();
        }

        public static dynamic suma(dynamic a, dynamic b)
        {
            return a+b;
        }

        static dynamic Funct(dynamic obj) {
            return obj.getValue();
        }
    }
}
