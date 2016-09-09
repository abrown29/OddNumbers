using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //print out odd nums from 1-99 inclusive
            //start at one, make condition <=99, add 2 after each loop
            int counter;
            for (counter = 1; counter <=99; counter += 2)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
