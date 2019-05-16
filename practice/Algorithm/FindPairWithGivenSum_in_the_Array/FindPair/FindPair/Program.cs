using System;

//Give an unsorted array of integers, find a pair with given sum in it.
//Input:
//arr = [8, 7, 2, 5, 3, 1 ]
//sum = 10

//Output
//Pari found at index 0 and 2(8+2)
//or
//Pair found at index 1 and 4 (7+3)


namespace FindPair
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 8, 7, 2, 5, 3, 1 };
            int sum = 10;
            int n = arr.Length;

            findPair(arr, n, sum);
        }

        //Naive method to find a pair in an array with given sum
        public static void findPair(int[] arr, int n, int sum)
        {
            //consider each element except last element
            for ( int i = 0; i < n-1; i++)
            {
                //start from i\'th element till last element 
                for ( int j = i+1; j < n; j++)
                {
                    // if desired sum is found, print it and return 
                    if(arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine("Pari found at {0}, {1}", i, j);
                    }
                }
            }
            // No pair with given sum exists in the array 
            Console.WriteLine("pair not found");
        }
    }
}
