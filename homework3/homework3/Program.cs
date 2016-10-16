using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {// Prompt the user to enter the amount of seconds to be converted.
            Console.WriteLine("Enter the amount of seconds to be converted:");
            String secs = Console.ReadLine();
            double Secs = double.Parse(secs);
            double convert_day = 0.00001157407;
            double convert_hour = 0.00027777;
            double convert_min = 0.0166666;
            double num_day = convert_day * Secs;
            double num_hour = convert_hour * Secs;
            double num_min = convert_min * Secs;

            Console.WriteLine("Your time in days is {0}", num_day);
            Console.WriteLine("Your time in hours is {0}", num_hour);
            Console.WriteLine("Your time in minutes is {0}", num_min);
            Console.WriteLine("Your time in seconds is {0}", Secs);

            Console.ReadLine();

        }
    }
}
