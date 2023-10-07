using System;

namespace CsharpProject2_2
{
    class Complex
    {
        private double realPart, imagePart;
        public double RealPart
        {
            get { return realPart; }
            set { realPart = value; }
        }
        public double ImagePart
        {
            get { return imagePart; }
            set { imagePart = value; }
        }
        public Complex()
        {
            realPart = 0;
            imagePart = 0;
        }
        public Complex(double a, double b) {
            realPart = a;
            imagePart = b;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            Complex answer = new Complex();
            answer.RealPart=a.RealPart+b.RealPart;
            answer.ImagePart=a.ImagePart+b.ImagePart;
            return answer;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex answer = new Complex();
            answer.RealPart = a.RealPart - b.RealPart;
            answer.ImagePart = a.ImagePart - b.ImagePart;
            return answer;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex answer = new Complex();
            answer.RealPart = (a.RealPart * b.RealPart) - (a.ImagePart * b.ImagePart); ;
            answer.ImagePart = (a.RealPart * b.ImagePart) + (a.ImagePart * b.RealPart);
            return answer;
        }
        public static Complex operator /(Complex a, Complex b)
        {
            Complex answer = new Complex();
            answer.RealPart =
                (a.RealPart * b.RealPart + a.ImagePart * b.ImagePart) / (b.RealPart * b.RealPart + b.ImagePart * b.ImagePart); ;

            answer.ImagePart = 
                (a.ImagePart * b.RealPart - a.RealPart*b.ImagePart) / (b.RealPart * b.RealPart + b.ImagePart * b.ImagePart);
            return answer;
        }
        public override string ToString()
        {
            if (RealPart == 0 & ImagePart == 0)
            {
                return ("0");
            }
            else if (RealPart == 0)
            {
                return (ImagePart + "i");
            }
            else if (ImagePart == 0)
            {
                return (""+RealPart);
            }
            else if (ImagePart < 0)
            {
                return ("(" + realPart +""+ imagePart + "i" + ")");
            }
            else
            {
                return ("(" + realPart + "+" + imagePart + "i" + ")");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex a= new Complex(2,3);
            Complex b= new Complex(1,2);
            Console.WriteLine("a");
            Console.WriteLine(a);
            Console.WriteLine("b");
            Console.WriteLine(b);
            Console.WriteLine("a + b");
            Console.WriteLine(a + b);
            Console.WriteLine("a - b");
            Console.WriteLine(a - b);
            Console.WriteLine("a * b");
            Console.WriteLine(a * b);
            Console.WriteLine("a / b");
            Console.WriteLine(a / b);
        }
    }
}