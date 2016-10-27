using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3__Mandatory_
{
    class Program
    {
        static void Main(string[] args) //

        {
            Console.WriteLine("Please input the integer you wish to have factorialized:");
            string thingy = Console.ReadLine();
            int pseudothingy = int.Parse(thingy);
            int superthingy = 1;
            while (pseudothingy > 1)
            { superthingy = (superthingy*pseudothingy);
              pseudothingy = pseudothingy - 1;
            }
            Console.WriteLine("your answer is {0}", superthingy);
            Console.ReadLine();



        }
    }
}
