using System;
using System.Text.RegularExpressions;

namespace RegexE
{
    class Program
    {
        static void Main(string[] args)
        {

            //string pattern = @"\d";
            //Regex regex = new Regex(pattern);

            //string text = "Hi there, my number is 12314";

            //MatchCollection matchCollection = regex.Matches(text);

            //Console.WriteLine("{0} hits found: \n {1}", matchCollection.Count, text);

            //foreach(Match hit in matchCollection)
            //{
            //    GroupCollection group = hit.Groups;
            //    Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            //}

            //DateTime tomorrow = GetTomorrow();
            //Console.WriteLine("Tomorrow will be the {0}", tomorrow);

            //Console.WriteLine("Write a date in this format: yyyy-mm-dd");

            //string input = Console.ReadLine();
            //DateTime dateTime;
            //if (DateTime.TryParse(input, out dateTime))
            //{
            //    Console.WriteLine(dateTime);
            //    TimeSpan dayPasser = DateTime.Now.Subtract(dateTime);

            //    Console.WriteLine("Days passed since: {0}", dayPasser.Days);
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Input");
            //}

            Shape[] shapes = { new Sphere(4), new Cube(3) };
            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());

                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shpae is no cube");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("This shape a cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} has a volume of {1}", cube2.Name, cube2.Volume());

            }

        }


        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
