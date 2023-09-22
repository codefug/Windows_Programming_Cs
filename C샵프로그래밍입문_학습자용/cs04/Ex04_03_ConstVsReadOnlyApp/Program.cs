using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVsReadOnlyApp
{
    public class Color
    {
        public const int FULL = 0xFF;              // constant member
        public const int EMPTY = 0x00;             // constant member
        private byte red, green, blue;

        // readonly fields
        public static readonly Color Red = new Color(FULL, EMPTY, EMPTY);
        public static readonly Color Green = new Color(EMPTY, FULL, EMPTY);
        public static readonly Color Blue = new Color(EMPTY, EMPTY, FULL);
        
        public Color(byte r, byte g, byte b)
        {     // constructor
            red = r;
            green = g;
            blue = b;
        }
        public static void PrintColor(Color c)
        {   // method
            Console.WriteLine("red value={0}, green value={1}, blue value={2}",
                c.red, c.green, c.blue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //내가 쓴거임.
            // static field 처럼 const나 static readonly는
            // 클래스 명으로 접근해야 된다.

            Color c = new Color(11, 22, 33);
            // Console.WriteLine("FULL = " + c.FULL);
            
            Console.WriteLine("FULL = " + Color.FULL);
            Color.PrintColor(Color.Red);
        }
    }
}