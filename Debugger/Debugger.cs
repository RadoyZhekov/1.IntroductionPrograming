using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
    class Debugger
    {
        static void Main(string[] args)
        {
            int number = 1;
            for (int i = number; i <= 1000; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
