using System;
using System.Reflection;

namespace LR6
{
    class Program
    {
        public delegate string Stringing(int x, double y);

        static void Main(string[] args)
        {
            // Delegate Testing
            Apply(MakeStringSum, 20, 25.5);
            Apply((x, y) => $"{x} - {y} = {(x - y)}", 20, 25.5);

            // Func<> Testing
            ApplyFunc(MakeStringSum, 20, 25.5);
            ApplyFunc((x, y) => $"{x} - {y} = {(x - y)}", 20, 25.5);


            Console.WriteLine();
            // Reflection Testing

            var aInfo = typeof(A);
            var propertyInfos = aInfo.GetProperties();
            var methodInfos = aInfo.GetMethods();
            var constructorInfos = aInfo.GetConstructors();

            Console.WriteLine("Properties:");
            foreach (var info in propertyInfos)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine();

            Console.WriteLine("Methods:");
            foreach (var info in methodInfos)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine();

            Console.WriteLine("Constructors:");
            foreach (var info in constructorInfos)
            {
                Console.WriteLine(info);
            }
            Console.WriteLine();

            Console.WriteLine("Attributed Properties:");
            foreach (var info in propertyInfos)
            {
                if (Attribute.IsDefined(info, typeof(MyAttribute)))
                {
                    Console.WriteLine(info);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Call MethodString:");
            Console.WriteLine(aInfo.GetMethod("MethodString").Invoke(new A(17, 24.34, "25"), null));
        }

        public static void ApplyFunc(Func<int, double, string> f, int param1, double param2)
        {
            Console.WriteLine(f(param1, param2));
        }

        public static void Apply(Stringing f, int param1, double param2)
        {
            Console.WriteLine(f(param1, param2));
        }

        public static string MakeStringSum(int x, double y)
        {
            return $"{x} + {y} = {(x + y)}";
        }   
    }
}