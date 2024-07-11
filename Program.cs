using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineArgument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numberArray = new double[5];
            double sum, avg, max, min;

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = Convert.ToDouble(args[i]);
            }

            //summation
            sum = numberArray.Sum();

            //average
            avg = sum / 5;

            //maximum & minimum
            max = numberArray.Max();
            min = numberArray.Min();

            Console.WriteLine("Sum: " + sum + "\nAverage: " + avg + "\nMaximum: " + max + "\nMinimum: " + min);

        }


    }
}
