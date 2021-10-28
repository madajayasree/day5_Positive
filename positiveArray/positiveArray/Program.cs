using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            int[] result;
            result = new int[10];   
            int n ;
     
            Console.WriteLine("How many numbers do you want to enter: ");
            n = Convert.ToInt32(Console.ReadLine());
            num = new int[n];
            for(int i = 0; i < num.Length ; i++)
            {
                Console.WriteLine("Enter {0}st elements: ", i+1);
                num[i]= int.Parse( Console.ReadLine());
            }

            Console.WriteLine("List of positive elements : ");
            for(int j = 0; j< num.Length;j++)
            {
                if (num[j] >= 0)
                {
                    result[j] = num[j];
                    Console.WriteLine(result[j] + " ");
                }
                
            }
            Console.WriteLine();

        }
    }
}
