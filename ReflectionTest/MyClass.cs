using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTest
{
    public class MyClass
    {
        private int _age = 2042;
        public string ClassName = "Calculo 2";
        static double mount = 28.5;

        public void PrintAge()
        {
            Console.WriteLine(_age);
        }
    }

}
