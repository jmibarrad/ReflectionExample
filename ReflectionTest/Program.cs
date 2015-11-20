using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Assembly-----");
            var asm = Assembly.GetExecutingAssembly();
            var asmTypes = asm.GetTypes();
            foreach (var asmType in asmTypes) {
                Console.WriteLine(asmType.Name);
            }

            Console.WriteLine("\n-----------Reflection-----");
            var objType = Type.GetType("ReflectionTest.MyClass");
            var obj = Activator.CreateInstance(objType);
            Console.WriteLine(obj.GetType().FullName);
            //var objType = obj.GetType();
            var objFields = objType.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach(var field in objFields)
            {
                Console.WriteLine(field.Name);
            }
            var ageField = objType.GetField("_age", BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(ageField.FieldType.FullName);
            ageField.SetValue(obj, 2000);
            var printAgeMethod = objType.GetMethod("PrintAge");
            // if method is static then obj == null
            printAgeMethod.Invoke(obj, null);
            Console.ReadKey();
        }
    }
}
