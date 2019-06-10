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

            // naive approach
            // O(n^2) and space complexty O(1)
            findPair(arr, n, sum);

            // O(nLog(n)) solution using Sorting
            findPairAlternativWay(arr, n, sum);
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
        // The Idea is to sort the given array in ascending order and maintain search space by
        // maintaining two indices(low and high)

        public static void findPairAlternativWay(int[] arr, int n, int sum)
        {
            // Sort the array in ascending order
            Array.Sort(arr);

            // maintain two indices pointing to end-points of the array

            int low = 0;
            int high = n - 1;

            // reduce search space arr[low..high] at each iteration of the loop

            // loop till low is less than high
            while(low < high)
            {
                // sum found
                if(arr[low] + arr[high] == sum)
                {
                    Console.WriteLine("Pair Found");
                    return;

                }
                // increment low index if total is less than the desired sum
                // decrement high index is total is more than the sum
                if (arr[low] + arr[high] < sum)
                {
                    low++;
                } else {
                    high--;
                }
                
            }
            // Now pair with given sum exists in the array
            Console.WriteLine("Pair not found");
        }
    }
}
