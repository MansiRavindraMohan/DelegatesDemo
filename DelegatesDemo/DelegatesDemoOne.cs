using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class DelegatesDemoOne
    {
        public static void MethodOne(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public static void MethodTwo(int x, int y)
        {
            Console.WriteLine(x-y);
        }
    }
}
