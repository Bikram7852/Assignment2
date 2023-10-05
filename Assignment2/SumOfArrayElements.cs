using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class SumOfArrayElements
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1,2,3,4 };
            for(int i = 0; i < 4; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of all the elements of array: " + sum);
            Console.ReadLine();
        }
    }
}
