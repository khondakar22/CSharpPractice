using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace JaggedArray
{
    public class ArrayListExample
    {
        public static void GetArrayList()
        {
            ArrayList myArrayList = new ArrayList();
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add(13.17);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            myArrayList.Remove(13);

            // delete element t specific position
            myArrayList.RemoveAt(0);

            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach (object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                } else if(obj is double)
                {
                    sum += (double)obj;
                } else if( obj is string)
                {
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        } 
    }
}
