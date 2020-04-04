using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the birthday wishes", true, "Denis Panjuta!");

            Console.WriteLine(post1.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my new Shoes", "Denis Panujta", "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
            VideoPost videoPost1 = new VideoPost("FailVideo", "Denis Panjuta", "https://video.com/failvideo", true, 10);
            Console.WriteLine(videoPost1.ToString());
            videoPost1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            videoPost1.Stop();
          
            Console.ReadLine();
            //ShortesFired.GetShortesFriend();
            //string[] joesFamily = new string[] { "Martha", "Robert" };

            //string[][] friendsAndFamily = new string[][]
            //{
            //    new string[]{"Michael", "Sandy"},
            //    new string[]{"Frank", "Claudia"},
            //    new string[]{"Andrew", "Michelle"},
            //    joesFamily
            //};
            //Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][0], friendsAndFamily[1][0]);
            //Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][0]);
            //Console.WriteLine("Hi {0}, I would like to introduce {1} to you.", friendsAndFamily[0][1], friendsAndFamily[2][1]);

            //int[] happiness = { 2, 4, 5, 6 };
            //SunIsShining(happiness);

            //foreach (int y in happiness)
            //{
            //    Console.WriteLine(y);
            //}



            //int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            //double averageResult = GetAverage(studentsGrades);

            //foreach (int grade in studentsGrades)
            //{
            //    Console.WriteLine("{0}", grade);
            //}
            //Console.WriteLine("The average is: {0}", averageResult);
            //Console.ReadKey();
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i]; 
            }
            average = (double)sum / size;

            return average;
        }

        static void SunIsShining(int[] x)
        {
          
            for (int i = 0; i<x.Length; i++)
            {
                x[i] += 2;
            }
        }
    }
}
