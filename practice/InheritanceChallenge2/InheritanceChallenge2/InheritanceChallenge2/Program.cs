using System;

namespace InheritanceChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee michael = new Employee("Michael", "Miller", 40000);
            michael.Work();
            michael.Pause();

            Boss chuckNorris = new Boss("Ferrari", "Norris", "Chuck", 99999999);
            chuckNorris.Lead();
            Console.ReadKey();
        }
    }
}
