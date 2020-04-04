using System;

namespace _07____Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10]; 
            for(int i = 0; i<10; i++)
            {
                nums[i] = i + 10; 
            }
            for(int j=0; j<10; j++)
            {
                Console.WriteLine("Element{0} = {1}", j, nums[j]);
            }
            Console.ReadKey();
        }
    }
}
