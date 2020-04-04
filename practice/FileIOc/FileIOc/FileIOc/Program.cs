using System;
using System.IO;
namespace FileIOc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method 1
            string[] lines = { "First 250", "Second 650", "Third 985" };

            //File.WriteAllLines(@"D:\c_sharp\CSharpPractice\practice\FileIOc\FileIOc\FileIOc\textFile2.txt", lines);

            // Method 2
            //Console.WriteLine("Please give the file a name");
            //string fileName = Console.ReadLine();
            //Console.WriteLine("Please Enter the text for the file");
            //string input = Console.ReadLine();
            //File.WriteAllText(@"D:\c_sharp\CSharpPractice\practice\FileIOc\FileIOc\FileIOc\" + fileName + ".txt", input);

            // Method 3

            using(StreamWriter file = new StreamWriter(@"D:\c_sharp\CSharpPractice\practice\FileIOc\FileIOc\FileIOc\myText.txt"))
            {
                foreach (string line in lines)
                {
                    if(line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using(StreamWriter file = new StreamWriter(@"D:\c_sharp\CSharpPractice\practice\FileIOc\FileIOc\FileIOc\myText.txt", true))
            {
                file.WriteLine("Additional Line ");
            }

            //// Example 1 - reading text
            //string text = System.IO.File.ReadAllText(@"D:\c_sharp\CSharpPractice\practice\FileIOc\FileIOc\FileIOc\textFile.txt");
            //Console.WriteLine("TextFile contains following text: {0}", text);
          

            //string[] lines = System.IO.File.ReadAllLines(@"D:\c_sharp\CSharpPractice\practice\FileIOc\FileIOc\FileIOc\textFile.txt");
            //Console.WriteLine("Contents of Text file.txt: = ");
            //foreach (string line in lines)
            //{
            //    Console.WriteLine("\t" +  line);
            //}
            Console.ReadKey();
        }
    }
}
