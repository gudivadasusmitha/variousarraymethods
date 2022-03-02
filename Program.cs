using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variousarraymethods
{
    internal class Program
    {
        public static void Main()
        {
            int[] arr = new int[] { 1, 9, 7, 5, 9 };
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach(int value in arr)
            {
                Console.WriteLine(value + "  ");
            }
        }
    }
}
