using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Printer
    {
        public static void Print(int[] source)
        {
            for(int i = 0; i < source.Length; i++)
            {
                Console.Write(source[i] + " ");
            }
            Console.WriteLine("END");
        }
    }
}
