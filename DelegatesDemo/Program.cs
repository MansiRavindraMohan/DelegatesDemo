using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //the return type of a delegate should be same as method return type.
    public delegate int DelegateOne(int x, int y);
    public delegate void DelegateTwo(int x, int y);
    public class Program
    {
        public static void Main(string[] args)
        {
            DelegateExample delegateExample = new DelegateExample();
            DelegateOne delegateOne=new DelegateOne(delegateExample.FirstMethod);
            Console.WriteLine(delegateOne(30, 40));
            //delegateOne = new DelegateOne(delegateExample.SecondMethod);
            //Console.WriteLine(delegateOne(40, 30));
            delegateOne += delegateExample.SecondMethod;
            Console.WriteLine(delegateOne(40, 30));
            //Console.WriteLine(delegateExample.FirstMethod(20,30));
            //Console.WriteLine(delegateExample.SecondMethod(40,10));

            DelegatesDemoOne delegatesDemoOne = new DelegatesDemoOne();
            DelegateTwo delegateTwo = new DelegateTwo(DelegatesDemoOne.MethodOne);
            delegateTwo(2,3);
            delegateTwo += DelegatesDemoOne.MethodTwo;
            delegateTwo(20, 10);
            Console.ReadLine();
        }
    }
}
