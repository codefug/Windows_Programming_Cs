using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiddenNameApp
{
    class BaseClass
    {
        protected int a = 1;
        protected int b = 2;
    }
    class DerivedClass : BaseClass
    {
        new int a = 3; // if removing new, error occur
        new double b = 4.5;
        // which means they don't use the a, b of the parent class
        public void Output()
        {
            Console.WriteLine("BaseClass : a={0}, DerivedClass:a={1}",
                base.a, a);
            Console.WriteLine("BaseClass : b={0}, DerivedClass:b={1}",
                base.b, b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Output();
        }
    }
}