using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsMethods
{
    public static class UserInput
    {
        public static string ProcessUserInput(string userInput)
        {
            try
            {
                return userInput;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string numberInput = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string numberInput2 = Console.ReadLine();
            int num1 = int.Parse(numberInput);
            int num2 = int.Parse(numberInput2);

            int result = num1 + num2;
            return result;
        }

        public static void TryAndCatch()
        {
            Console.WriteLine("Please Enter a number");
            string userInput = Console.ReadLine();


            try
            {
                int userInputAsInt = int.Parse(userInput);
                Console.WriteLine(userInputAsInt);

            }
            catch (FormatException)
            {
                Console.WriteLine("Please write a correct type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, number is to long or too short for an int42");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }
        }

        public static void OperatorC()
        {
            int num1 = 5;
            int num2 = 4;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

        }

        public static void IfElseC()
        {
            Console.WriteLine("What is the temperature like?");
            string temperature = Console.ReadLine();
            //int numTemp = int.Parse(temperature);
            int numTemp;
            int number;
            bool userEnteredNumber = int.TryParse(temperature, out number);
            if (userEnteredNumber)
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered, was no number, 0 set as temperature");
            }

            if (numTemp < 10)
            {
                Console.WriteLine("Take the coat");
            }
            else if (numTemp == 20)
            {
                Console.WriteLine("Pant and Pull over should be fine");
            }
        }

        public static void Login()
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            userName = Console.ReadLine();

            if (isRegistered)
            {
                Console.WriteLine("Hi there, registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there" + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there Admin");
                    }
                }
            }
            if(isAdmin || isRegistered)
            {
                Console.Write("You are logged in");
            }
        }
    }

}
