using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the integer of the number of factorials you wish to display:");
            string thingy = Console.ReadLine();
            int pseudothingy = int.Parse(thingy);
            int x;
            int y=pseudothingy;
            int quickans=pseudothingy;
            
            for (y=pseudothingy;y>0;y--) 
            { 

                for (x = (pseudothingy - 1); x > 1; x--)
                {
                        
                        quickans=(x * quickans);
                    
                }
                Console.WriteLine("{0} = {1}", y, quickans);
                pseudothingy = pseudothingy - 1;
                quickans = pseudothingy;
            }
            
            Console.ReadLine();

        }
    }
}
