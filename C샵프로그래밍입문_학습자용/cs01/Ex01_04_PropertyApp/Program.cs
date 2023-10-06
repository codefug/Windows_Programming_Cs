using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class PropertyClass
    {
        private int privateValue;
        public int Accessprivatevalue
        {
            get { return privateValue; }  // get-accessor
            set { privateValue = value; }  // set-accessor
        }
        public void PrintValue()
        {
            Console.WriteLine("Hidden Value = " + privateValue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            PropertyClass obj = new PropertyClass();
            obj.Accessprivatevalue = 100;       // invoke set-accessor
            obj.PrintValue();
            n = obj.Accessprivatevalue;         // invoke get-accessor
            Console.WriteLine("       Value = " + n);
        }
    }
}
