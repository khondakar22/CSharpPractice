using System;

namespace DelegatesRR
{
    class Program
    {
        public delegate double PerformCalculation(double x, double y);

        public delegate string GetTextDelegate(string name);

        public static double Addition(double a, double b)
        {
            Console.WriteLine("a+b is :" + (a+b));
            return a + b;
        }
        public static double Division(double a, double b)
        {
            Console.WriteLine("a/b is :" + (a / b));
            return a / b;
        }

        public static double Subtraction(double a, double b)
        {
            Console.WriteLine("a-b is :" + (a - b));
            return a - b;
        }
        static void Main(string[] args)
        {
            PerformCalculation getSum = Addition;
            //getSum(5.0, 5.0);
            PerformCalculation getQuotient = Division;
            //getQuotient(5.0, 5.0);

            PerformCalculation multiCal = getSum + getQuotient;
            multiCal += Subtraction;
            multiCal(3.2, 3.2);

            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;
            };

            GetTextDelegate getHelloText = (string name) => { return "Hello, " + name; };

            // Statement lamda
            GetTextDelegate getGoodbyeText = (string name) => {
                Console.WriteLine("I'm inside of an statment lambda");
                return "Goodbye, " + name;
            };

            GetTextDelegate getWelcomeText = name => "Welcom, " + name;

            Console.WriteLine(getHelloText("Denis"));
        }
    }
}
