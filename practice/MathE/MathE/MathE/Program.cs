using System;

namespace MathE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your question");
            Console.ReadLine();
            Random yesNoMaybe = new Random();
            int answerNum;
            answerNum = yesNoMaybe.Next(1,7);
            if(answerNum == 1)
            {
                Console.WriteLine("Yes");
            } else if(answerNum ==2)
            {
                Console.WriteLine("Maybe");
            }else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();
        }
    }
}
