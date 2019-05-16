using System;

namespace FunctionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteSomething();
            //WriteSomethinsSpecific("I am an argument and am called from a method");
            //Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            //Console.WriteLine(Add(15, 31));
            //Console.WriteLine(Multiply(3, 4));
            //// GreatFriend
            //string input = Console.ReadLine();
            //string stringOfUser =  UserInput.ProcessUserInput(input);
            //Console.WriteLine(stringOfUser);


            //UserInput.TryAndCatch();
            UserInput.Login();
            Console.Read();
        }

        // access modifere(static) return type method name(parameter1, parameter2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");

        }

        public static void WriteSomethinsSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            try
            {
                return num1 + num2;
            }
            catch (Exception ex)
            {
                throw new Exception("The Error are->", ex);
            }
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;

        }
    }
}
